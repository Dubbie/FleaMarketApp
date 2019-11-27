# Flea market application
An application that handles a *virtual flea market* using MVP Passive View. The application does not handle payment processing, items are sold manually.

## Setup guide
If you want to fill the application with some test data you will have to do the following:
- After obtaining your copy of the application you will find a `sample_database.sql` file in the root folder
- Copy the file's content into your `.mdf` file
- Run the copied query in Visual Studio

## Using the application
There are two modes the application can run in.
- Administrator
- User

You can change between these modes by overwriting the `admin` element in the `FleaMarketApp\auth.xml` XML file.
*True* means **Administrator** mode, and *False* means **User** mode.

### Administrator
As an **Administrator** you can do the following:
- Add or modify items
- Browse and filter items
- Sell items
- Browse or delete item orders
- See order and income statistics

When you add an item, if you give it a price it gets the **Active** status, else it gets the **New** status and will need to be given a price later
The item will only be visible for **Users** if it's status is *Active*.

Item statuses can be the following:
- New
- Active
- Ordered
- Sold

Items are categorized into predefined categories.

### User
As a **User** you can do the following:
- Browse and filter items (Only **Active** items are seen)
- Order items
- Check your order
- Cancel orders

When you order an item, you will have to add your personal data:
- Name
- Address
- E-mail
- Phone

After successfully ordering, you will get an **Order ID**.
This is important because you can check your order details by this ID.
If you don't want an item, you can cancel it after the next business day of your order.
