using Google.Cloud.Firestore;

namespace Impressa.Shared.Models
{
    [FirestoreData]
    public class Employee
    {
        public string EmployeeId { get; set; }
        public DateTime? date { get; set; }
        [FirestoreProperty]
        public string EmployeeName { get; set; }
        [FirestoreProperty]
        public string CityName { get; set; }
        [FirestoreProperty]
        public string Designation { get; set; }
        [FirestoreProperty]
        public string Gender { get; set; }
    }
}
