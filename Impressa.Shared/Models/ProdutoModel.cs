using Google.Cloud.Firestore;

namespace Impressa.Shared.Models
{
    [FirestoreData]
    public class ProdutoModel
    {
        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public string Nome { get; set; }
        [FirestoreProperty]
        public string Descricao { get; set; }
        [FirestoreProperty]
        public double Preco { get; set; }
        [FirestoreProperty]
        public string Imagem { get; set; }

    }
}
