using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      JoinEntities = new HashSet<CategoryItem>();
    }

    public int ItemId { get; set; }
    public string Description { get; set; }
    public bool IsComplete { get; set; }
    public DateTime DueWhen { get; set; }

    public virtual ICollection<CategoryItem> JoinEntities { get; }
  }
}