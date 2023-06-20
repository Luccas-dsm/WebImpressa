using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;

namespace DataAccess.DomainService
{
    public class AdminWebBanco
    {

        Access BaseDeDados = new Access();
        public string AddArquivo(string bucketName,string fileName,string localImagePath)
        {
            try
            {
                // Crie uma instância do Google Cloud Storage
                StorageClient storageClient = StorageClient.Create(BaseDeDados.AcessoBaseWebBanco());

                // Abra um fluxo de leitura para o arquivo local
                using (var fileStream = File.OpenRead(localImagePath))
                {
                    // Faça o upload do arquivo para o Firebase Storage
                    // retorna o id do arquivo na base de dados
                    return storageClient.UploadObject(bucketName, fileName, null, fileStream).Id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        //public async Task<string> GetArquivo(string bucketName, string fileName) {

        //    try
        //    {
        //        // Crie uma instância do Google Cloud Storage
        //        StorageClient storageClient = StorageClient.Create(BaseDeDados.AcessoBaseWebBanco());



        //     var teste = await storageClient.GetObjectAsync(bucketName, fileName);

        //      storageClient.

        //        return  
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }

        //}
        public static UrlSigner FromBlobSigner(UrlSigner.IBlobSigner signer) { return null; }
    }
}
