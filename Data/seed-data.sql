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
('T-Shirt', 'Lorem ipsum dolor sit amet', 'Levis', 199, 'AAA111', 'https://st3.depositphotos.com/1144687/13132/i/600/depositphotos_131325550-stock-photo-girl-in-black-shirt.jpg', 'svart-tshirt', 180, 'Svart', '2023-05-29', 2),
('T-Shirt', 'Lorem ipsum dolor sit amet', 'Nike', 229, 'BBB111', 'https://st4.depositphotos.com/8025996/25694/i/600/depositphotos_256943604-stock-photo-attractive-brutal-tattooed-bearded-guy.jpg', 'vit-tshirt', 180, 'Vit', '2023-04-01', 2),
('T-Shirt', 'Lorem ipsum dolor sit amet', 'Nike', 229, 'AAA222', 'https://st4.depositphotos.com/16122460/27445/i/600/depositphotos_274454990-stock-photo-woman-in-bright-t-shirt.jpg', 'rosa-tshirt', 180, 'Rosa', '2023-04-29', 2),
('Jeans', 'Lorem ipsum dolor sit amet', 'Levi', 600, 'JJJ333', 'https://st4.depositphotos.com/7448508/38256/i/450/depositphotos_382562162-stock-photo-girl-jeans-shows-jeans-white.jpg', 'bla-jeans', 120, 'Blå', '2023-06-05', 6),
('Byxor', 'Lorem ipsum dolor sit amet', 'Second hand', 250, 'KKK123', 'https://st2.depositphotos.com/13193658/43152/i/450/depositphotos_431520334-stock-photo-partial-view-man-boots-standing.jpg', 'brun-byxa', 120, 'Brun', '2023-03-05', 5),
('Skjorta', 'Lorem ipsum dolor sit amet', 'Dressman', 400, 'SSS333', 'https://st3.depositphotos.com/12982378/36265/i/450/depositphotos_362657898-stock-photo-handsome-businessman-glasses-looking-away.jpg', 'bla-skjorta', 420, 'Blå', '2023-03-20', 7),
('Klänning', 'Lorem ipsum dolor sit amet', 'Adidas', 400, 'VVV321', 'https://st4.depositphotos.com/1310467/19841/i/450/depositphotos_198414878-stock-photo-beautiful-sexy-woman-yellow-dress.jpg', 'gul-klanning', 310, 'Gul', '2023-02-10', 3),
('Kappa', 'Lorem ipsum dolor sit amet', 'H&M', 800, 'VVV123', 'https://st4.depositphotos.com/13194036/39347/i/600/depositphotos_393470956-stock-photo-beautiful-elegant-girl-holding-trench.jpg', 'brun-kappa', 610, 'Brun', '2023-01-10', 1),
('Skinnjacka', 'Lorem ipsum dolor sit amet', 'H&M', 700, 'DDD456', 'https://st.depositphotos.com/1006318/4356/i/600/depositphotos_43565687-stock-photo-smiling-man-wearing-leather-jacket.jpg', 'svart-skinnjacka', 410, 'Svart', '2023-05-30', 1)


INSERT INTO Categories (
	Name
)
VALUES
('Jackor & Kappor'),
('Tröjor'),
('Klänningar'),
('Toppar & T-shirts'),
('Byxor'),
('Jeans'),
('Blusar & Skjortor')