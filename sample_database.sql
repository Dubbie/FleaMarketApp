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
        item_price DECIMAL(10,2),
        status_id   NUMERIC NOT NULL REFERENCES status(status_id),
        category_id NUMERIC NOT NULL REFERENCES category(category_id),
        created_at DATETIME NOT NULL,
        modified_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
    );

CREATE TABLE item_order
    (
        order_id    NUMERIC PRIMARY KEY IDENTITY(1,1),
        item_id    NUMERIC NOT NULL REFERENCES item(item_id),
		orderer_name VARCHAR(255) NOT NULL,
		orderer_address VARCHAR(255) NOT NULL,
		orderer_email VARCHAR(255) NOT NULL,
		orderer_phone VARCHAR(255) NOT NULL,
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
	(6, 'Bútor'),
    (7, 'Egyéb');
SET IDENTITY_INSERT category OFF

SET IDENTITY_INSERT item ON
INSERT INTO item (item_id, item_name, item_description, item_price, status_id, category_id, created_at, modified_at)
    VALUES
        (1, 'MVMT Karóra', 'Teljesen fekete, bőr szíjjal, piros mutatóval, alig használt', '16990.00', 2, 3, '2019-10-18 22:35:06', '2019-10-18 22:35:06'),
		(2, 'LG Monitor', 'LG Flatron E2242, 1920x1080 felbontás, inkább kisebb mint nagyobb', '10000.00', 4, 2, '2019-10-20 16:30:00', '2019-10-22 17:30:00'),
        (3, 'Gyulai kolbász', 'Enyhén csípős, pálinkáért felárat fizetek', '1500.00', 3, 7, '2019-10-23 23:40:06', '2019-11-03 09:16:49'),
        (4, 'Baywatch DVD', ';)', '5000.00', 4, 4, '2019-11-03 09:14:06', '2019-11-03 09:14:06'),
		(5, 'Barbi Baba', 'Olyan szép mint az én Barbi babám :)', '1000000.00', 3, 4, '2019-11-25 17:25:30', '2019-11-25 20:35:20'),
        (6, 'Nike Sapka', 'Fekete', '3000.00', 2, 1, '2019-11-26 14:13:06', '2019-11-26 14:13:06'),
        (7, 'Akusztikus Gitár', 'Hordtáskával együtt', '15000.00', 3, 4, '2019-11-26 14:14:06', '2019-11-26 14:14:06'),
        (8, 'Kakaós bögre', 'Cuki kis macskás mintával, gyönyörű állapotban', '490.00', 3, 7, '2019-11-20 16:30:00', '2019-11-22 17:30:00'),
		(9, 'AOC Monitor', 'AOC 22P1D, Pivot állványos, 1920x1080 felbontás, inkább kisebb mint nagyobb', '30000.00', 3, 2, '2019-10-24 14:04:00', '2019-10-25 17:30:00'),
		(10, 'Razer Blackwidow Ultimate', '2012-es példány, egyike a korai mechanikus billentyűzetek közül', NULL, 1, 2, '2019-10-26 12:00:00', '2019-10-26 12:00:00'),
		(11, 'Logitech G920', 'Professzionális gamer kormány, 900 fokot fordul, 3 pedálos, H váltóval', '65000.00', 4, 2, '2019-10-28 00:00:00', '2019-11-05 00:00:00'),
		(12, 'Dohányzóasztal', 'Kicsit kopottas, fehér színű', '2000.00', 2, 6, '2019-10-29 00:00:00', '2019-10-29 10:00:00'),
		(13, 'Ezüst nyaklánc', 'A nyakláncon lóg egy ezüstözött B betű', '10000.00', 4, 6, '2019-10-30 00:00:00', '2019-10-30 08:00:00');
SET IDENTITY_INSERT item OFF

SET IDENTITY_INSERT item_order ON
INSERT INTO item_order (order_id, item_id, orderer_name, orderer_address, orderer_email, orderer_phone, ordered_at) VALUES
(1, 2, 'Mihó Dániel', '2440 Százhalombatta, Pannónia u. 11 2./9.', 'miho.daniel@mdy.hu', '06308266701', '2019-11-03 09:16:49'),
(2, 4, 'Mihó Dániel', '2440 Százhalombatta, Pannónia u. 11 2./9.', 'miho.daniel@mdy.hu', '06308266701', '2019-11-25 20:35:20'),
(3, 7, 'Mihó Dániel', '2440 Százhalombatta, Pannónia u. 11 2./9.', 'miho.daniel@mdy.hu', '06308266701', '2019-11-22 17:30:00'),
(4, 9, 'Mihó Dániel', '2440 Százhalombatta, Pannónia u. 11 2./9.', 'miho.daniel@mdy.hu', '06308266701', '2019-10-25 17:30:00'),
(5, 11, 'Mihó Dániel', '2440 Százhalombatta, Pannónia u. 11 2./9.', 'miho.daniel@mdy.hu', '06308266701', '2019-11-05 00:00:00'),
(6, 13, 'Mihó Dániel', '2440 Százhalombatta, Pannónia u. 11 2./9.', 'miho.daniel@mdy.hu', '06308266701', '2019-10-30 08:00:00');
GO
SET IDENTITY_INSERT item_order OFF