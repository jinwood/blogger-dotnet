CREATE DATABASE BloggerDotNet;

CREATE TABLE dbo.Posts(
	PostId int IDENTITY,
	Reference varchar(15),
	MdContent nvarchar(MAX),
	DateCreated DateTime,
	DateDeleted DateTime
);

ALTER TABLE dbo.Posts ADD CONSTRAINT PK_PostId
   PRIMARY KEY(PostId);