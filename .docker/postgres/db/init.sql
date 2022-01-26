CREATE TABLE IF NOT EXISTS cars (
  id SERIAL PRIMARY KEY,
  name character varying(50) NOT NULL UNIQUE,
  price int NOT NULL
);