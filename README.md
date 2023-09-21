# CMPG-323-Project-3-40604012
This web application project made for EcoPower Logistics ensures that the best practices are implemented in code, making use of the repository pattern to ensure code reuse.

## How to use this Restful API project:
This Web application can either be used by cloning the main repository, however this is not recommended since the appsettings.json file and thus the connection string to the database will not be accessible to the stakeholders. The wwwroot file will also not be included. If the stakeholder has access to the appsettings.json file as well as the wwwroot folder they can use this method, however it is recomended that they alternativly access the Web App being hosted on Azure at [this URL](https://ecopowerlogisticswebapplication.azurewebsites.net). (This will only be accessible by approved users within the resource group in which this App Service is being hosted.)

## How to use the Web App:
### Table of Contents
- [Authentication](#authentication)
- [Customers](#customers)
- [Orders](#orders)
- [Products](#products)

### Authentication:

When first accessing the website, the user will be greated by the EcoPower Logistics Home page which looks like this:

![HomePage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/48acd7cd-1ae5-4830-8275-6cb34b200b6e)

As is - a user will not be able to access the functionality of the app unless they register or log in:

1. Register (If you do not have an existing account):

   ![RegisterPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/a9d37432-fa41-4385-8f33-390e8ee1e52c)

   Click on the register button and fill in the relevant details to create an account. Once you are done you will be able to access the web application.

2. Login (If you already have an account)

   ![LoginPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/ae7b25b7-a37c-4977-a2ae-16cd7c2e73ef)

   Click on the login button, fill in your username and password and click log in to log in with your registered account.

Once you have successfully done either of these approaches, you will notice your email on the top right hand corner of the screen, along with a logout option as well as the options to now access Customers, Orders and Products:

![EmailAddress](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/a36fe06a-560b-4c9b-888a-78c04346cb6b)

### Customers

To access the customer table of the database, simply click on the Customer option on the Home Screen. You will then be redirected to this page:

![CustomerPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/2c2a4953-2328-4e87-9d3e-0c380a11ed5d)

Here you can perform various functions:

1. Create New ~ Creates a new customer entry in the database table:

   ![CreateCustomerPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/1b7d14db-45c9-490b-b149-5adb0a148248)

  Steps:
  - Click on the Create New Hyperlink
  - Fill in the requested fields and click create

2. Edit ~ Edits a customer entry in the database table

   ![EditCustomerPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/d0ae94fe-3f65-4ae0-9001-33390585d376)

   Steps:
  - Click on the Edit Hyperlink next to the entry you want to edit
  - Edit one or more fields and click save

3. Details ~ Views the details of a customer entry in the database table

   ![CustomerDetailsPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/9ce61d56-ec08-4b88-b7b5-42ee27e2ebae)

   Steps:
  - Click on the Details Hyperlink next to the entry you want to edit
  - You will be able to see the details of that table object

4. Delete ~ Deletes a customer entry in the database table

   ![DeleteCustomerPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/8139dbea-1948-45ea-bceb-f9c1bc99fb11)

   Steps:
  - Click on the Delete Hyperlink next to the entry you want to delete
  - Click the Delete button to confirm and that entry will be deleted

### Orders

To access the order table of the database, simply click on the Order option on the Home Screen. You will then be redirected to this page:

![OrderPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/7a9ae7e0-5581-4117-8d6e-698ad31ad9bd)

Here you can perform various functions:

1. Create New ~ Creates a new order entry in the database table:

   ![CreateOrderPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/2f41b53a-cb2d-4de8-b558-9c6bc9e75118)

  Steps:
  - Click on the Create New Hyperlink
  - Fill in the requested fields and click create

2. Edit ~ Edits an order entry in the database table

   ![EditOrderPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/042d2f0a-c240-4028-be42-c7f9bdb4ca31)

   Steps:
  - Click on the Edit Hyperlink next to the entry you want to edit
  - Edit one or more fields and click save

3. Details ~ Views the details of an order entry in the database table

   ![OrderDetailsPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/8f288d0d-28bc-4cd7-85ff-387df6331b59)

   Steps:
  - Click on the Details Hyperlink next to the entry you want to edit
  - You will be able to see the details of that table object

4. Delete ~ Deletes an order entry in the database table

   ![DeleteOrderPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/9241256f-d971-4929-bd41-ab8c5be30962)

   Steps:
  - Click on the Delete Hyperlink next to the entry you want to delete
  - Click the Delete button to confirm and that entry will be deleted

### Products

To access the products table of the database, simply click on the Products option on the Home Screen. You will then be redirected to this page:

![ProductsPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/5305c5fa-743d-410a-9423-1f0b1edeea88)

Here you can perform various functions:

1. Create New ~ Creates a new product entry in the database table:

   ![CreateProductPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/837d2d7f-2611-427a-88e4-3058df09723c)

  Steps:
  - Click on the Create New Hyperlink
  - Fill in the requested fields and click create

2. Edit ~ Edits a product entry in the database table

   ![EditProductPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/76bdfd58-867c-45bb-8b44-736540f16592)

   Steps:
  - Click on the Edit Hyperlink next to the entry you want to edit
  - Edit one or more fields and click save

3. Details ~ Views the details of a product entry in the database table

   ![ProductDetailsPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/cafbd252-9208-4823-98af-c9478fc21277)

   Steps:
  - Click on the Details Hyperlink next to the entry you want to edit
  - You will be able to see the details of that table object

4. Delete ~ Deletes a product entry in the database table

   ![DeleteProductPage](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/assets/104925498/d026701d-edee-4fc7-a1c9-acecc009e39e)

   Steps:
  - Click on the Delete Hyperlink next to the entry you want to delete
  - Click the Delete button to confirm and that entry will be deleted

## References
The following list of references were used to complete this project: 
[Project3References.xlsx](https://github.com/lvdv4j/CMPG-323-Project-3-40604012/files/12679668/Project3References.xlsx)

## Stretch Tasks
The following stretch tasks were done for the project:
- Splitting the implementation of the design pattern between projects: This took me a really long time to do after the base project was completed. Trying to implement this resulted in numerous errors, however I managed to resolve them all and achieved this implementation before the project milestone due date.


