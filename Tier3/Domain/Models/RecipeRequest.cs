using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

// posting a Recipe basically means creating a RecipeRequest
// that has to be approved by the admin
public class RecipeRequest : Recipe
{
    public bool Response { get; set; }
    [ForeignKey(nameof(User.Id))]
    public int RequestedByUserId { get; set; }
    public User RequestedByUser { get; set; }
    /*// Foreign Key
    [ForeignKey(nameof(User.Id))]
    public new int UserId = new Recipe().UserId;
    public User User { get; set; }*/
}