
//Convertisseur.cs => pour récupérer les données de l'API
namespace MetropolitanMuseum.Convertisseur
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    // Nouvelle structure pour désérialiser le JSON de la nouvelle API


    public class DepartmentContainer
    {

        [JsonPropertyName("departments")]
        public List<Department> Departments { get; set; }


        public class Department
        {
            [JsonPropertyName("departmentId")]
            public int DepartmentId { get; set; }


            [JsonPropertyName("displayName")]
            public string DisplayName { get; set; }




        }
    }
}
