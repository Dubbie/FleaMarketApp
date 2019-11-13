IF OBJECT_ID('item_order') IS NOT NULL DROP TABLE item_order;
IF OBJECT_ID('item') IS NOT NULL DROP TABLE item;
IF OBJECT_ID('category') IS NOT NULL DROP TABLE category;
IF OBJECT_ID('status') IS NOT NULL DROP TABLE status;

GO
CREATE TABLE status
    (
        status_id      NUMERIC PRIMARY KEY IDENTITY(1,1),
        status_name    VARCHAR(40) 
    );

CREATE TABLE category 
    (
        category_id   NUMERIC PRIMARY KEY IDENTITY(1,1),
        category_name    VARCHAR(40)
    ); 

CREATE TABLE item
    (
        item_id    NUMERIC PRIMARY KEY IDENTITY(1,1),
        item_name  VARCHAR(255) NOT NULL,
        item_description VARCHAR(255),
        item_price DECIMAL(10,2) NOT NULL,
        status_id   NUMERIC NOT NULL REFERENCES status(status_id),
        category_id NUMERIC NOT NULL REFERENCES category(category_id),
        created_at DATETIME NOT NULL,
        modified_at DATETIME DEFAULT CURRENT_TIMESTAMP
    );

CREATE TABLE item_order
    (
        order_id    NUMERIC PRIMARY KEY IDENTITY(1,1),
        item_id    NUMERIC NOT NULL REFERENCES item(item_id),
        ordered_at DATETIME NOT NULL
    );
GO

SET IDENTITY_INSERT status ON
INSERT INTO status (status_id, status_name) VALUES
    (1, 'Új'),
    (2, 'Aktív'),
    (3, 'Megrendelt'),
    (4, 'Eladott');
SET IDENTITY_INSERT status OFF

SET IDENTITY_INSERT category ON
INSERT INTO category (category_id, category_name) VALUES
    (1, 'Ruházat'),
    (2, 'Elektronika'),
    (3, 'Óra & Ékszer'),
    (4, 'Sport & Szórakozás'),
    (5, 'Játékok'),
    (6, 'Egyéb');
SET IDENTITY_INSERT category OFF

SET IDENTITY_INSERT item ON
INSERT INTO item (item_id, item_name, item_description, item_price, status_id, category_id, created_at, modified_at)
    VALUES
        (1, 'MVMT Karóra', 'Teljesen fekete, bőr szíjjal, piros mutatóval, alig használt', '16990.00', 2, 3, '2019-10-18 22:35:06', '2019-10-18 22:35:06'),
        (2, 'Baywatch DVD', ';)', '5000.00', 3, 4, '2019-11-03 09:14:06', '2019-11-03 09:14:06');
SET IDENTITY_INSERT item OFF

SET IDENTITY_INSERT item_order ON
INSERT INTO item_order (order_id, item_id, ordered_at) VALUES
(1, 2, '2019-11-03 09:16:49');
GO
SET IDENTITY_INSERT item_order OFF