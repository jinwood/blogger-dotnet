CREATE TABLE dbo.Posts(
	PostId int IDENTITY,
	Reference varchar(15),
	MdContent nvarchar(MAX),
	HtmlContent nvarchar(MAX),
	DateCreated DateTime,
	DateDeleted DateTime
);

ALTER TABLE dbo.Posts ADD CONSTRAINT PK_PostId
   PRIMARY KEY(PostId);