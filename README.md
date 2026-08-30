"# HexaStoreEcommerce-dotNetCore5-MVC" 
HexaStore is a complete E-Commerce Application built for online shopping, developed using C# and ASP.NET Core MVC.

The application provides a seamless shopping experience divided into two main components:

1. For Customers:
Product Catalog: Browse products organized by categories (Electronics, Clothing, Jewelry) with uniform, high-quality images.

Shopping Cart: Add, remove, and adjust item quantities with instant total cost calculation.

Seamless Checkout: Enter shipping details and process payments securely.

Multi-Language Support: Easily switch the user interface between Arabic and English.

2. For Administrators:
Admin Dashboard: Manage products (Add, Edit, Delete) and track customer orders.

User & Category Management: Organize categories and control user access rights.

Automated Data Seeding: Automatically creates the database, configures the default Admin account, and seeds initial products on first launch.

3. Payment Processing (Stripe Integration):
Secure Online Payments: Integrated with Stripe Gateway to handle credit card transactions safely without storing sensitive card data.

Automated Order Status: Updates order status automatically from Pending to Approved upon payment verification.

Refund Management: Built-in capability to manage order cancellations and process refunds smoothly.

4. Technical Features & Architecture:
N-Tier Architecture: Cleanly organized into separate layers (Entities, Data Access, Utilities, and Web UI) for scalability and maintainability.

Identity & Role-Based Access: Robust security using ASP.NET Core Identity to manage permissions for Admins, Editors, and Customers.

EF Core Data Management: Leverages Entity Framework Core for database migrations and ORM operations.

Responsive Design: Fully responsive layout built with Bootstrap for desktop, tablet, and mobile devices.

In Short: HexaStore is a well-structured, production-ready e-commerce solution that seamlessly connects product management, shopping carts, secure Stripe payments, and admin controls.
