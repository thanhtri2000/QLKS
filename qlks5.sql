USE [master]
GO

/****** Object:  Database [PMQLKS5]    Script Date: 2020-11-11 08:15:26 AM ******/
CREATE DATABASE [PMQLKS5]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PMQLKS5', FILENAME = N'T:\win\PMQLKS5.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PMQLKS5_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PMQLKS5_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PMQLKS5].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [PMQLKS5] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [PMQLKS5] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [PMQLKS5] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [PMQLKS5] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [PMQLKS5] SET ARITHABORT OFF 
GO

ALTER DATABASE [PMQLKS5] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [PMQLKS5] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [PMQLKS5] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [PMQLKS5] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [PMQLKS5] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [PMQLKS5] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [PMQLKS5] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [PMQLKS5] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [PMQLKS5] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [PMQLKS5] SET  DISABLE_BROKER 
GO

ALTER DATABASE [PMQLKS5] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [PMQLKS5] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [PMQLKS5] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [PMQLKS5] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [PMQLKS5] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [PMQLKS5] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [PMQLKS5] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [PMQLKS5] SET RECOVERY FULL 
GO

ALTER DATABASE [PMQLKS5] SET  MULTI_USER 
GO

ALTER DATABASE [PMQLKS5] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [PMQLKS5] SET DB_CHAINING OFF 
GO

ALTER DATABASE [PMQLKS5] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [PMQLKS5] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [PMQLKS5] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [PMQLKS5] SET QUERY_STORE = OFF
GO

ALTER DATABASE [PMQLKS5] SET  READ_WRITE 
GO


