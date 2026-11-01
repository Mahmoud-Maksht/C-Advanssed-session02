namespace C__Advanced_session_02.ShopMaster;

public class Product
{
    #region Q1

    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books"
    public double Price { get; set; }
    public int Stock { get; set; }
    #endregion
}
