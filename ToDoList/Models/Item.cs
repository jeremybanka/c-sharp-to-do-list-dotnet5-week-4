using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      this.JoinEntries = new HashSet<CategoryItem>();
    }

    public int ItemId { get; set; }
    public string Description { get; set; }

    public virtual ICollection<CategoryItem> JoinEntries { get;}
  }
}