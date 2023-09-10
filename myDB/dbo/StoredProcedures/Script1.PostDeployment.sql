IF NOT EXISTS (SELECT 1 FROM dbo.[User])
BEGIN
    INSERT INTO dbo.[User] (FirstName, LastName)
    VALUES
        ('Tina', 'Mahana'),
        ('Arram', 'Hu'),
        ('Tsu', 'Storm'),
        ('John', 'Smith'),
        ('Marry', 'Cross');
END
-- You can add an ELSE clause here to specify what to do if the data already exists.
-- For example, you can update existing records or perform some other action.
-- ELSE
-- BEGIN
--     -- Your alternative logic here
-- END
