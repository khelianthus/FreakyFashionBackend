INSERT INTO Products (
   Name,
   Description,
   Brand,
   Price,
   Sku,
   ImageUrl,
   UrlSlug,
   Likes,
   Color,
   CreatedAt,
   CategoryId
)
VALUES
('T-Shirt', 'Lorem ipsum dolor sit amet', 'Levis', 199, 'AAA111', 'https://via.placeholder.com/320x480.png', 'svart-tshirt', 180, 'Svart', '2023-05-29', 2),
('T-Shirt', 'Lorem ipsum dolor sit amet', 'Nike', 229, 'BBB111', 'https://via.placeholder.com/320x480.png', 'vit-tshirt', 180, 'Vit', '2023-05-29', 2)

INSERT INTO Categories (
	Name
)
VALUES
('Byxor'),
('Tröjor'),
('Väskor'),
('Skor')