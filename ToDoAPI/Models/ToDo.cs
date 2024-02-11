using System.ComponentModel.DataAnnotations;

namespace ToDoAPI.Models
{   
    public class ToDo
    {
        public int Id {get; set;}
        public string? ToDoName {get; set;}
    }
}