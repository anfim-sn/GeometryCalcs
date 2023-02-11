-- create a tables
CREATE TABLE products (
  prod_id INTEGER PRIMARY KEY,
  prod_name TEXT NOT NULL
);
CREATE TABLE categories (
  ctg_id INTEGER PRIMARY KEY,
  ctg_name TEXT NOT NULL
);
CREATE TABLE products_categories (
  id INTEGER PRIMARY KEY,
  prod_id INTEGER,
  ctg_id INTEGER,
  FOREIGN KEY (prod_id) REFERENCES products(prod_id),
  FOREIGN KEY (ctg_id) REFERENCES categories(ctg_id)
);
-- insert some values
INSERT INTO products VALUES (1, "Notebook");
INSERT INTO products VALUES (2, "Computer");
INSERT INTO products VALUES (3, "Knife");
INSERT INTO products VALUES (4, "Humidifier");
INSERT INTO products VALUES (5, "door");

INSERT INTO categories VALUES (1, "Electronics");
INSERT INTO categories VALUES (2, "Kitchen");
INSERT INTO categories VALUES (3, "Home Office");

INSERT INTO products_categories VALUES (1, 1, 1);
INSERT INTO products_categories VALUES (2, 2, 1);
INSERT INTO products_categories VALUES (3, 2, 3);
INSERT INTO products_categories VALUES (4, 3, 2);
INSERT INTO products_categories VALUES (5, 4, 3);

-- fetch all product, category names pair, with product without categories
SELECT prod.prod_name, ctg.ctg_name 
FROM products prod 
LEFT JOIN products_categories pc ON pc.prod_id = prod.prod_id 
LEFT JOIN categories ctg ON pc.ctg_id = ctg.ctg_id