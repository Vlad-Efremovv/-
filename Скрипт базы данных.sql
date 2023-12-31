﻿USE [master]
GO
/****** Object:  Database [POBEDA_BD]    Script Date: 09.10.2023 22:48:33 ******/
CREATE DATABASE [POBEDA_BD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'POBEDA_BD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\POBEDA_BD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'POBEDA_BD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\POBEDA_BD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [POBEDA_BD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POBEDA_BD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POBEDA_BD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [POBEDA_BD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [POBEDA_BD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [POBEDA_BD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [POBEDA_BD] SET ARITHABORT OFF 
GO
ALTER DATABASE [POBEDA_BD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [POBEDA_BD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [POBEDA_BD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [POBEDA_BD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [POBEDA_BD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [POBEDA_BD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [POBEDA_BD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [POBEDA_BD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [POBEDA_BD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [POBEDA_BD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [POBEDA_BD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [POBEDA_BD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [POBEDA_BD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [POBEDA_BD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [POBEDA_BD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [POBEDA_BD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [POBEDA_BD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [POBEDA_BD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [POBEDA_BD] SET  MULTI_USER 
GO
ALTER DATABASE [POBEDA_BD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [POBEDA_BD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [POBEDA_BD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [POBEDA_BD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [POBEDA_BD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [POBEDA_BD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [POBEDA_BD] SET QUERY_STORE = OFF
GO
USE [POBEDA_BD]
GO
/****** Object:  Table [dbo].[ArrayBD]    Script Date: 09.10.2023 22:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArrayBD](
	[Id] [int] NOT NULL,
	[Num] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_ArrayBD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [POBEDA_BD] SET  READ_WRITE 
GO
