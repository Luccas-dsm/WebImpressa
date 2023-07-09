using Google.Cloud.Firestore;

namespace Impressa.Shared.Models
{
    [FirestoreData]
    public class ArquivoModel
    {
        [FirestoreProperty]
        public string? Nome { get; set; }
        public byte[]? Conteudo { get; set; }

        [FirestoreProperty]
        public string? Url { get; set; }
        [FirestoreProperty]
        public string? Tipo { get; set; }
    }
}
