using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enginesoft.AmazonAwsS3Sample
{
    public class AwsS3Client
    {
        public delegate void LogEventHandler(string message);
        public event LogEventHandler LogReported;

        public Models.AwsCredential Credential { get; private set; }

        public AwsS3Client(Models.AwsCredential credential)
        {
            this.Credential = credential;
        }

        public void UploadFile(string bucketName, string localFilePath, string serverPath, int? cacheControlMaxAgeSeconds = null)
        {
            using (var fileStream = new FileStream(localFilePath, FileMode.Open))
            {
                UploadStream(bucketName, fileStream, serverPath, cacheControlMaxAgeSeconds);
            }
        }

        public void UploadImage(string bucketName, Image image, System.Drawing.Imaging.ImageFormat imageFormat, string serverPath, int? cacheControlMaxAgeSeconds = null)
        {
            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, imageFormat);
                this.UploadStream(bucketName, memoryStream, serverPath, cacheControlMaxAgeSeconds);
            }
        }

        public void UploadStream(string bucketName, System.IO.Stream stream, string serverPath, int? cacheControlMaxAgeSeconds = null)
        {
            //ref: http://docs.aws.amazon.com/AmazonS3/latest/dev/UploadObjSingleOpNET.html
                        
            using (var client = new AmazonS3Client(this.Credential.AcesssKey, this.Credential.SecretKey, this.Credential.Region))
            {
                PutObjectRequest putRequest2 = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = serverPath,
                    InputStream = stream
                };

                if (cacheControlMaxAgeSeconds.HasValue)
                    putRequest2.Headers.CacheControl = string.Format("max-age={0}, public", cacheControlMaxAgeSeconds);

                PutObjectResponse response2 = client.PutObject(putRequest2);
            }
        }

        public List<string> ListItems(string bucketName, string serverFolder, int? maxItems = null)
        {
            //ref: http://docs.aws.amazon.com/AmazonS3/latest/dev/RetrievingObjectUsingNetSDK.html

            List<string> listRest = new List<string>();
            int count = 0;

            var region = Amazon.RegionEndpoint.GetBySystemName(this.Credential.Region);

            using (var client = new AmazonS3Client(this.Credential.AcesssKey, this.Credential.SecretKey, region))
            {
                ListObjectsRequest request = new ListObjectsRequest
                {
                    BucketName = bucketName,
                    MaxKeys = 10,
                    Prefix = serverFolder
                };

                do
                {
                    ListObjectsResponse response = client.ListObjects(request);

                    // Process response
                    foreach (S3Object entry in response.S3Objects)
                    {
                        if (entry.Key == serverFolder || entry.Key == string.Format("{0}/", serverFolder) || entry.Key == string.Format("/{0}", serverFolder))
                            continue; //Folder

                        count++;

                        System.Diagnostics.Debug.WriteLine("AwsS3 -- key = {0} size = {1} / {2} items read", entry.Key, entry.Size.ToString("#,##0"), count.ToString("#,##0"));
                        listRest.Add(entry.Key);
                    }

                    // If response is truncated, set the marker to get the next 
                    // set of keys.
                    if (response.IsTruncated)
                    {
                        request.Marker = response.NextMarker;
                    }
                    else
                    {
                        request = null;
                    }

                    if (maxItems.HasValue && count >= maxItems.Value)
                        break;

                } while (request != null);
            }

            return listRest;
        }

        public void DeleteItem(string bucketName, string keyName)
        {
            //ref: http://docs.aws.amazon.com/AmazonS3/latest/dev/DeletingOneObjectUsingNetSDK.html
                        
            using (var client = new AmazonS3Client(this.Credential.AcesssKey, this.Credential.SecretKey, this.Credential.Region))
            {
                DeleteObjectRequest deleteObjectRequest = new DeleteObjectRequest
                {
                    BucketName = bucketName,
                    Key = keyName
                };

                client.DeleteObject(deleteObjectRequest);

                Log(string.Format("AwsS3 -- Deleted {0}", keyName));
            }
        }
        
        public void DeleteAllItemsFolder(string bucketName, string serverFolder)
        {
            //ref: http://docs.aws.amazon.com/AmazonS3/latest/dev/RetrievingObjectUsingNetSDK.html
            
            int count = 0;
            using (var client = new AmazonS3Client(this.Credential.AcesssKey, this.Credential.SecretKey, this.Credential.Region))
            {
                ListObjectsRequest request = new ListObjectsRequest
                {
                    BucketName = bucketName,
                    MaxKeys = 10,
                    Prefix = serverFolder
                };

                do
                {
                    ListObjectsResponse response = client.ListObjects(request);

                    // Process response
                    foreach (S3Object entry in response.S3Objects)
                    {
                        if (entry.Key == serverFolder || entry.Key == string.Format("{0}/", serverFolder) || entry.Key == string.Format("/{0}", serverFolder))
                            continue; //Folder

                        count++;

                        //System.Diagnostics.Debug.WriteLine(string.Format("AwsS3 -- key = {0} size = {1} / {2} items read", entry.Key, entry.Size.ToString("#,##0"), count.ToString("#,##0")));

                        this.DeleteItem(bucketName, entry.Key);

                        Log(string.Format("{0} -- {1} items deleted", entry.Key, count.ToString("#,##0")));
                    }

                    // If response is truncated, set the marker to get the next 
                    // set of keys.
                    if (response.IsTruncated)
                    {
                        request.Marker = response.NextMarker;
                    }
                    else
                    {
                        request = null;
                    }
                } while (request != null);
            }
        }

        private void Log(string message)
        {
            if (this.LogReported != null)
                this.LogReported(message);
        }
    }
}
