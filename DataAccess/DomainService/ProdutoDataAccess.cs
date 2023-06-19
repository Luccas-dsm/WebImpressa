using Google.Cloud.Firestore;
using Impressa.Shared.Models;
using Newtonsoft.Json;

namespace DataAccess.DomainService
{
    public class ProdutoDataAccess
    {
        Access fireStoreDb = new Access("genesis-93f18");

        private string Tabela = "Produtos";
        public async Task<List<ProdutoModel>> GetAllProducts()
        {
            try
            {
                Query employeeQuery = fireStoreDb.AcessoBase().Collection(this.Tabela);
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
                DocumentReference docRef = fireStoreDb.AcessoBase().Collection(this.Tabela).Document(id);
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
                CollectionReference colRef = fireStoreDb.AcessoBase().Collection("Produtos");
                await colRef.AddAsync(produto);
            }
            catch
            {
                throw;
            }
        }

    }
}
