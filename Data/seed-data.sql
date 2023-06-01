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
('T-Shirt', 'Lorem ipsum dolor sit amet', 'Levis', 199, 'AAA111', 'https://via.placeholder.com/320x480.png?text=Svart+T-shirt', 'svart-tshirt', 180, 'Svart', '2023-05-29', 2),
('T-Shirt', 'Lorem ipsum dolor sit amet', 'Nike', 229, 'BBB111', 'https://via.placeholder.com/320x480.png?text=Vit+T-shirt', 'vit-tshirt', 180, 'Vit', '2023-05-29', 2)
('T-Shirt', 'Lorem ipsum dolor sit amet', 'Nike', 229, 'AAA222', 'https://via.placeholder.com/320x480.png?text=Rosa+T-shirt', 'rosa-tshirt', 180, 'Rosa', '2023-05-29', 2)

INSERT INTO Categories (
	Name
)
VALUES
('Byxor'),
('Tröjor'),
('Väskor'),
('Skor')