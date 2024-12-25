using System.ComponentModel.DataAnnotations;

namespace ExBook.Models;

public class ComicBook
{
    [Key]
    public int CustomerBooksID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal PricePerday { get; set; }
    public ICollection<RentalDetail> RentalDetails { get; set; }
}