USE [master]
GO
/****** Object:  Database [CoachManagement]    Script Date: 10/25/2022 6:18:35 PM ******/
CREATE DATABASE [CoachManagement]
GO
USE [CoachManagement]
GO
/****** Object:  Table [dbo].[Coach]    Script Date: 10/25/2022 6:18:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coach](
	[NumberPlate] [varchar](50) NOT NULL,
	[Seats] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[Brand] [nvarchar](100) NULL,
	[Location] [nvarchar](200) NULL,
 CONSTRAINT [PK_Coach] PRIMARY KEY CLUSTERED 
(
	[NumberPlate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Driver]    Script Date: 10/25/2022 6:18:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Driver](
	[Id] [varchar](20) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Position] [varchar](50) NOT NULL,
	[Birthday] [date] NOT NULL,
	[NumberPlate] [varchar](50) NULL,
 CONSTRAINT [PK_Driver] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passenger]    Script Date: 10/25/2022 6:18:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passenger](
	[Id] [varchar](20) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Passenger] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 10/25/2022 6:18:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[BookTime] [datetime2](7) NOT NULL,
	[SeatNumber] [int] NOT NULL,
	[PassengerId] [varchar](20) NOT NULL,
	[TripId] [bigint] NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trip]    Script Date: 10/25/2022 6:18:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trip](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[From] [nvarchar](50) NOT NULL,
	[To] [nvarchar](50) NOT NULL,
	[DepartTime] [datetime2](7) NOT NULL,
	[Status] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[NumberPlate] [varchar](50) NULL,
 CONSTRAINT [PK_Trip] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Driver]  WITH CHECK ADD  CONSTRAINT [FK_Driver_Coach] FOREIGN KEY([NumberPlate])
REFERENCES [dbo].[Coach] ([NumberPlate])
GO
ALTER TABLE [dbo].[Driver] CHECK CONSTRAINT [FK_Driver_Coach]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Passenger] FOREIGN KEY([PassengerId])
REFERENCES [dbo].[Passenger] ([Id])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Passenger]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Trip] FOREIGN KEY([TripId])
REFERENCES [dbo].[Trip] ([Id])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Trip]
GO
ALTER TABLE [dbo].[Trip]  WITH CHECK ADD  CONSTRAINT [FK_Trip_Coach] FOREIGN KEY([NumberPlate])
REFERENCES [dbo].[Coach] ([NumberPlate])
GO
ALTER TABLE [dbo].[Trip] CHECK CONSTRAINT [FK_Trip_Coach]
GO
USE [master]
GO
ALTER DATABASE [CoachManagement] SET  READ_WRITE 
GO
