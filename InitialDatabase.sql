USE [BattleShip]
GO
/****** Object:  Table [dbo].[Attacker]    Script Date: 27/2/2564 15:46:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attacker](
	[AttackerId] [varchar](50) NOT NULL,
	[NewGameId] [varchar](50) NOT NULL,
	[ShootRow] [int] NOT NULL,
	[ShootColumn] [int] NOT NULL,
	[ShootStatus] [varchar](10) NOT NULL,
	[DefenderId] [varchar](50) NULL,
 CONSTRAINT [PK_Attacker] PRIMARY KEY CLUSTERED 
(
	[AttackerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Defender]    Script Date: 27/2/2564 15:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Defender](
	[DefenderId] [varchar](50) NOT NULL,
	[NewGameId] [varchar](50) NOT NULL,
	[ShipSeq] [int] NOT NULL,
	[Row1] [int] NOT NULL,
	[Column1] [int] NOT NULL,
	[Row2] [int] NOT NULL,
	[Column2] [int] NOT NULL,
	[DefenderStatus] [varchar](50) NULL,
 CONSTRAINT [PK_Defender] PRIMARY KEY CLUSTERED 
(
	[DefenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewGame]    Script Date: 27/2/2564 15:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewGame](
	[NewGameId] [varchar](50) NOT NULL,
	[StartGameDatetime] [datetime] NOT NULL,
	[EndGameDatetime] [datetime] NULL,
	[DefenderStatus] [varchar](1) NULL,
	[AttackerWinStatus] [varchar](1) NULL,
 CONSTRAINT [PK_NewGame] PRIMARY KEY CLUSTERED 
(
	[NewGameId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'05a7581f-599c-4e96-9300-b93472bfb0f6', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 3, 4, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'399bce6c-fdda-4488-be16-95be67c283fa', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 2, 2, N'Hit', N'D0FE269C-B41E-465C-A999-92CE1F4E0416')
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'4a6899f1-9802-4e04-bf47-2f07bcc4a2f7', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 2, 3, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'4cc6bf89-5017-439b-864b-47a758e522f2', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 1, 3, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'55960614-8cb1-4092-9a28-713db5efe47b', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 2, 2, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'578badb9-2735-4276-bb27-753ae3ab0e2c', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 2, 1, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'606b0b0c-049a-4c6e-aea3-e6c126581686', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 2, 3, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'6b900344-54bf-4153-92f7-9bc7cd226f45', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 3, 1, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'6f292201-2260-4cb1-aa83-c39e854d64d4', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 3, 1, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'76a49aac-aae0-4c85-8911-749723809610', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 2, 1, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'7d77cbb2-2a1c-4ef4-8158-c151f1cff148', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 2, 2, N'Hit', N'D0FE269C-B41E-465C-A999-92CE1F4E0416')
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'87f17757-e7f1-4482-874e-b50258f5193a', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 4, 3, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'9da56c3e-8d9e-4de7-8d9b-fe0083198223', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 1, 4, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'a1ff8b85-24e5-4bf0-9a34-3b49e2823736', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 3, 4, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'b3a7202a-85bd-4db1-9706-976e329dbc11', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 3, 3, N'Miss', NULL)
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'c7632ee4-f42e-42f9-b899-21904e13c800', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 4, 2, N'Hit', N'D887DC96-328F-4FEA-99CD-7C337FED8D3A')
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'f979a029-1fa5-499c-83ff-83cbff080604', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 4, 1, N'Hit', N'D887DC96-328F-4FEA-99CD-7C337FED8D3A')
GO
INSERT [dbo].[Attacker] ([AttackerId], [NewGameId], [ShootRow], [ShootColumn], [ShootStatus], [DefenderId]) VALUES (N'fb596880-eed3-413d-b4a5-b7cfb63bebf4', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 1, 1, N'Miss', NULL)
GO
INSERT [dbo].[Defender] ([DefenderId], [NewGameId], [ShipSeq], [Row1], [Column1], [Row2], [Column2], [DefenderStatus]) VALUES (N'D0FE269C-B41E-465C-A999-92CE1F4E0416', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 1, 2, 1, 2, 2, N'Mark X')
GO
INSERT [dbo].[Defender] ([DefenderId], [NewGameId], [ShipSeq], [Row1], [Column1], [Row2], [Column2], [DefenderStatus]) VALUES (N'D887DC96-328F-4FEA-99CD-7C337FED8D3A', N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', 2, 4, 1, 4, 2, N'Mark X')
GO
INSERT [dbo].[NewGame] ([NewGameId], [StartGameDatetime], [EndGameDatetime], [DefenderStatus], [AttackerWinStatus]) VALUES (N'55b87c8c-b2f1-40e5-926b-2ea72a135e0b', CAST(N'2021-02-26T15:22:22.473' AS DateTime), NULL, N'N', N'N')
GO
ALTER TABLE [dbo].[NewGame] ADD  CONSTRAINT [DF_NewGame_DefenderStatus]  DEFAULT ('N') FOR [DefenderStatus]
GO
ALTER TABLE [dbo].[NewGame] ADD  CONSTRAINT [DF_NewGame_AttackerWinStatus]  DEFAULT ('N') FOR [AttackerWinStatus]
GO
ALTER TABLE [dbo].[Attacker]  WITH CHECK ADD  CONSTRAINT [FK_Attacker_NewGame] FOREIGN KEY([NewGameId])
REFERENCES [dbo].[NewGame] ([NewGameId])
GO
ALTER TABLE [dbo].[Attacker] CHECK CONSTRAINT [FK_Attacker_NewGame]
GO
ALTER TABLE [dbo].[Defender]  WITH CHECK ADD  CONSTRAINT [FK_Defender_NewGame] FOREIGN KEY([NewGameId])
REFERENCES [dbo].[NewGame] ([NewGameId])
GO
ALTER TABLE [dbo].[Defender] CHECK CONSTRAINT [FK_Defender_NewGame]
GO
