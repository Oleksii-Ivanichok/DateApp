using System.ComponentModel.DataAnnotations.Schema;

namespace DateApp.Entities;

[Table("Photos")]

public class Photo
{
    public int Id { get; set; }
    public string Url { get; set; }
    public bool isMain { get; set; }
    
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; }

}