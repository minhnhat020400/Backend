

use AppChatUme
Create table UserAccount
(
	idUser Integer identity(0,1)  NOT NULL, UNIQUE (idUser),
	phoneNumber Varchar(10) NOT NULL,
	password Varchar(16) NULL,
	createOn Datetime NULL,
	updateOn Datetime NULL,
	isActive Bit Default 1 NULL,
	sex Bit NULL,
	birthDay date NULL,
	email varchar(2000) NULL,
	Primary Key (idUser)
   
) 


Create table UserAvarta
(
	idAvarta Integer identity(0,1)  NOT NULL,
	url Varchar(200) NULL,
	createOn Datetime NULL,
	updateOn Datetime NULL,
	isActive Bit Default 1 NULL,
	Primary Key (idAvarta),
    idUser Integer not null,
    FOREIGN KEY (idUser) REFERENCES UserAccount(idUser) on update cascade on delete cascade
) ;


Create table Message
(
	idMessage Integer identity(0,1)  NOT NULL,
	idUser Integer NOT NULL,
	toUserId Integer NOT NULL,
	status Nvarchar(20) NULL,
	isActive Bit Default 1 NULL,
	createOn Datetime NULL,
	IisGim Bit Default 0 NULL,
	viewOn Datetime NULL,
	Primary Key (idMessage),
	FOREIGN KEY (idUser) REFERENCES UserAccount(idUser) on update cascade on delete cascade
) ;


Create table GroupChat
(
	idGroup Integer identity(0,1)  NOT NULL,
	numberMember Integer NULL,
	avartaGroup Varchar(200) NULL,
	isActive Bit Default 1 NULL,
	createOn Datetime NULL,
	updateOn Datetime NULL,
	Primary Key (idGroup)
) ;

Create table InfoGroup
(
	idUser Integer NOT NULL,
	idGroup Integer NOT NULL,
	dateJoin Datetime NULL,
	isActive Bit Default 1 NULL,
	Primary Key (idUser,idGroup),
	FOREIGN KEY (idUser) REFERENCES UserAccount(idUser) on update cascade on delete cascade,
	FOREIGN KEY (idGroup) REFERENCES GroupChat(idGroup) on update cascade on delete cascade
) ;

Create table groupChatMessage
(
	idMess Integer identity(0,1)  NOT NULL,
	idUser Integer NOT NULL,
	idGroup Integer NOT NULL,
	status Varchar(20) NULL,
	toUserId Integer NOT NULL,
	createOn Datetime NULL,
	isGim Bit Default 0 NULL,
	Primary Key (idMess),
	FOREIGN KEY (idUser) REFERENCES UserAccount(idUser) on update cascade on delete cascade,
	FOREIGN KEY (idGroup) REFERENCES GroupChat(idGroup) on update cascade on delete cascade
) ;

Create table Poster
(
	idPoster Integer  identity(0,1)  NOT NULL,
	imgPoster Varchar(800) NULL,
	content Nvarchar(3000) NULL,
	createOn Datetime NOT NULL,
	isActive Bit Default 1 NULL,
    likeNumber int default 0,
    idUser int not null,
	Primary Key (idPoster),
    FOREIGN KEY (idUser) REFERENCES UserAccount(idUser) on update cascade on delete cascade
);

Create table Liked
(
	
	isLike bit default 0,
	idPoster Integer ,
	idUser Integer NOT NULL,
	dateAction Datetime NOT NULL,
	updateTime Datetime NULL,
	Primary Key (idPoster,idUser),
    FOREIGN KEY (idPoster) REFERENCES Poster(idPoster)  on delete cascade,
    FOREIGN KEY (idUser) REFERENCES UserAccount(idUser) on update cascade on delete cascade
) 

Create table Comment
(
	idComment Integer  identity(0,1)  NOT NULL,
	createOn Datetime NOT NULL,
	content Nvarchar(2000) NULL,
	idUser Integer NOT NULL,
	idPoster Integer NOT NULL,
    isActive bit default 1,
	Primary Key (idComment),
    FOREIGN KEY (idUser) REFERENCES UserAccount(idUser) on delete cascade,
    FOREIGN KEY (idPoster) REFERENCES Poster(idPoster) on update cascade on delete cascade
    
);

Create table UserNotification
(
	idNotification Integer  identity(0,1)  NOT NULL,
	isRead Bit Default 0 NULL,
	content Nvarchar(2000) NOT NULL,
	creataOn Datetime NULL,
	readOn Datetime NULL,
	idUser Integer NOT NULL,
	Primary Key (idNotification),
    FOREIGN KEY (idUser) REFERENCES UserAccount(idUser) on update cascade on delete cascade
) ;
-- thêm 1 người dùng
select * from UserAccount



