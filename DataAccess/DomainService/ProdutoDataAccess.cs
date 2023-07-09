using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;

using Impressa.Shared.Models;
using Newtonsoft.Json;

namespace DataAccess.DomainService
{
    public class ProdutoDataAccess
    {
        Access BaseDeDados = new Access("genesis-93f18");

        private string Tabela = "produto";
        public async Task<List<ProdutoModel>> GetAllProducts()
        {
            try
            {
                Query employeeQuery = BaseDeDados.AcessoBaseFireStore().Collection(this.Tabela);
                QuerySnapshot employeeQuerySnapshot = await employeeQuery.GetSnapshotAsync();
                List<ProdutoModel> lstEmployee = new List<ProdutoModel>();

                foreach (DocumentSnapshot documentSnapshot in employeeQuerySnapshot.Documents)
                {
                    if (documentSnapshot.Exists)
                    {
                        Dictionary<string, object> city = documentSnapshot.ToDictionary();
                        string json = JsonConvert.SerializeObject(city);
                        ProdutoModel newuser = JsonConvert.DeserializeObject<ProdutoModel>(json);
                        newuser.Id = documentSnapshot.Id;
                        lstEmployee.Add(newuser);
                    }
                }

                List<ProdutoModel> sortedEmployeeList = lstEmployee.OrderBy(x => x.Nome).ToList();
                return sortedEmployeeList;
            }
            catch
            {
                throw;
            }
        }

        public async Task<ProdutoModel> GetPrdutoByID(string id)
        {
            try
            {
                DocumentReference docRef = BaseDeDados.AcessoBaseFireStore().Collection(this.Tabela).Document(id);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    ProdutoModel emp = snapshot.ConvertTo<ProdutoModel>();
                    emp.Id = snapshot.Id;
                    return emp;
                }
                else
                {
                    return new ProdutoModel();
                }
            }
            catch
            {
                throw;
            }
        }
        public async void addProduto(ProdutoModel produto)
        {
            try
            {


                //// Crie uma instância do Google Cloud Storage
                //StorageClient storageClient = StorageClient.Create(BaseDeDados.AcessoBaseWebBanco());

                //// Defina o nome do bucket onde deseja salvar a imagem
                //string bucketName = "web_banco";

                //// Defina o nome do arquivo para salvar no Firebase Storage
                //string fileName = "categoria.jpg";

                //// Caminho local da imagem que você deseja carregar
                //string localImagePath = "D:\\sites\\blazor\\Impressa\\Client\\wwwroot\\assets\\categoria-sm.png";

                //// Abra um fluxo de leitura para o arquivo local
                //using (var fileStream = File.OpenRead(localImagePath))
                //{
                //    // Faça o upload do arquivo para o Firebase Storage
                //  produto.Imagem = storageClient.UploadObject(bucketName, fileName, null, fileStream).Id;
                //}

                //CollectionReference colRef = BaseDeDados.AcessoBaseFireStore().Collection("Produtos");
                //await colRef.AddAsync(produto);
            }
            catch
            {
                throw;
            }
        }

    }
}
