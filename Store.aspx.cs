using System;
using System.Web.UI;

public partial class Store : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Code for page load if needed (you can leave this empty if not required)
    }

    // Handle ListBox selection change event
    protected void lstItems_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Get the selected item from the ListBox
        string selectedItem = lstItems.SelectedValue;

        // Set the image and price based on the selected item
        SetItemDetails(selectedItem);
    }

    // Handle Button click to show the price of the selected product
    protected void btnShowPrice_Click(object sender, EventArgs e)
    {
        string selectedItem = lstItems.SelectedValue;

        // Display price of the selected item
        string price = GetItemPrice(selectedItem);
        lblPrice.Text = "Price: " + price;
    }

    // Helper method to set image based on selected item
    private void SetItemDetails(string item)
    {
        switch (item)
        {
            case "Laptop":
                storeImage.ImageUrl = "~/Images/laptop.jpg";
                storeImage.Visible = true;
                break;
            case "Smartphone":
                storeImage.ImageUrl = "~/Images/smartphone.jpg";
                storeImage.Visible = true;
                break;
            case "Tablet":
                storeImage.ImageUrl = "~/Images/tablet.jpg";
                storeImage.Visible = true;
                break;
            case "Headphones":
                storeImage.ImageUrl = "~/Images/headphones.jpg";
                storeImage.Visible = true;
                break;
            case "Smartwatch":
                storeImage.ImageUrl = "~/Images/smartwatch.jpg";
                storeImage.Visible = true;
                break;
            default:
                storeImage.Visible = false;
                break;
        }
    }

    // Helper method to return the price of the selected item
    private string GetItemPrice(string item)
    {
        switch (item)
        {
            case "Laptop":
                return "$1200";
            case "Smartphone":
                return "$800";
            case "Tablet":
                return "$500";
            case "Headphones":
                return "$150";
            case "Smartwatch":
                return "$250";
            default:
                return "Item not available";
        }
    }
}
