using Google.Cloud.Firestore;

namespace Impressa.Shared.Models
{
    [FirestoreData]
    public class CategoriaModel
    {
        [FirestoreProperty]
        public string? Seq { get; set; }
        [FirestoreProperty]
        public string? Nome { get; set; }
    }
}
