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
('T-Shirt', 'Lorem ipsum dolor sit amet', 'Levis', 199, 'AAA111', 'https://st3.depositphotos.com/1144687/13132/i/600/depositphotos_131325550-stock-photo-girl-in-black-shirt.jpg', 'svart-tshirt', 180, 'Svart', '2023-05-29', 4),
('T-Shirt', 'Lorem ipsum dolor sit amet', 'Nike', 229, 'BBB111', 'https://st4.depositphotos.com/8025996/25694/i/600/depositphotos_256943604-stock-photo-attractive-brutal-tattooed-bearded-guy.jpg', 'vit-tshirt', 180, 'Vit', '2023-04-01', 4),
('T-Shirt', 'Lorem ipsum dolor sit amet', 'Nike', 229, 'AAA222', 'https://st4.depositphotos.com/16122460/27445/i/600/depositphotos_274454990-stock-photo-woman-in-bright-t-shirt.jpg', 'rosa-tshirt', 180, 'Rosa', '2023-04-29', 4),
('Jeans', 'Lorem ipsum dolor sit amet', 'Levi', 600, 'JJJ333', 'https://st4.depositphotos.com/7448508/38256/i/450/depositphotos_382562162-stock-photo-girl-jeans-shows-jeans-white.jpg', 'bla-jeans', 120, 'Blå', '2023-06-05', 6),
('Byxa', 'Lorem ipsum dolor sit amet', 'Secondhand', 250, 'KKK123', 'https://st2.depositphotos.com/13193658/43152/i/450/depositphotos_431520334-stock-photo-partial-view-man-boots-standing.jpg', 'brun-byxa', 120, 'Brun', '2023-03-05', 5),
('Skjorta', 'Lorem ipsum dolor sit amet', 'Dressman', 400, 'SSS333', 'https://st3.depositphotos.com/12982378/36265/i/450/depositphotos_362657898-stock-photo-handsome-businessman-glasses-looking-away.jpg', 'bla-skjorta', 420, 'Blå', '2023-03-20', 7),
('Klänning', 'Lorem ipsum dolor sit amet', 'Addidas', 400, 'VVV321', 'https://st4.depositphotos.com/1310467/19841/i/450/depositphotos_198414878-stock-photo-beautiful-sexy-woman-yellow-dress.jpg', 'gul-klanning', 310, 'Gul', '2023-02-10', 3),
('Kappa', 'Lorem ipsum dolor sit amet', 'H&M', 800, 'VVV123', 'https://st4.depositphotos.com/13194036/39347/i/600/depositphotos_393470956-stock-photo-beautiful-elegant-girl-holding-trench.jpg', 'brun-kappa', 610, 'Brun', '2023-01-10', 1),
('Skinnjacka', 'Lorem ipsum dolor sit amet', 'H&M', 700, 'DDD456', 'https://st.depositphotos.com/1006318/4356/i/600/depositphotos_43565687-stock-photo-smiling-man-wearing-leather-jacket.jpg', 'svart-skinnjacka', 410, 'Svart', '2023-05-30', 1),
('Klänning', 'Lorem ipsum dolor sit amet', 'Antik', 800, 'FKE796', 'https://images.unsplash.com/photo-1585487000160-6ebcfceb0d03?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=734&q=80', 'lila-klanning', 610, 'Lila', '2023-06-06', 3),
('Tröja', 'Lorem ipsum dolor sit amet', 'Dressman', 400, 'DDR631', 'https://images.unsplash.com/photo-1611246164691-97f352683561?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=687&q=80', 'orange-troja', 240, 'Orange', '2023-05-15', 2),
('Tröja', 'Lorem ipsum dolor sit amet', 'Lindex', 300, 'TTG631', 'https://images.unsplash.com/photo-1638759233888-2245e01b6415?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=764&q=80', 'rod-troja', 440, 'Röd', '2023-06-07', 2),
('Blus', 'Lorem ipsum dolor sit amet', 'Lindex', 300, 'MOB341', 'https://images.unsplash.com/photo-1549062572-544a64fb0c56?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=687&q=80', 'vit-blus', 440, 'Vit', '2023-06-01', 7),
('Kappa', 'Lorem ipsum dolor sit amet', 'Secondhand', 799, 'MMM341', 'https://img.freepik.com/free-photo/portrait-beautiful-young-woman-with-mobile-phone_23-2148495518.jpg?w=740&t=st=1686162951~exp=1686163551~hmac=f2a53da8ab49ce39b774d574fc6979706b1ba4d565eb54decc69670c38991ae6', 'bla-kappa', 440, 'Blå', '2023-03-01', 1),
('T-shirt', 'Lorem ipsum dolor sit amet', 'Nike', 199, 'CCC321', 'https://img.freepik.com/free-photo/portrait-man-standing-isolated-white-background_23-2148043781.jpg?w=740&t=st=1686163413~exp=1686164013~hmac=db507581dd7dab94fb95cea634425a52394b11c9dddf9c4f54ef38ed3ae86ab2', 'gra-t-shirt', 210, 'Grå', '2023-04-18', 4)
