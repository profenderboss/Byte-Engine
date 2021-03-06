﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Window
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Window))
        Me.Sprites = New System.Windows.Forms.ImageList(Me.components)
        Me.Draw = New System.Windows.Forms.Timer(Me.components)
        Me.CenterPanel1 = New [Byte].CenterPanel()
        Me.Viewport1 = New [Byte].Viewport()
        Me.CenterPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Sprites
        '
        Me.Sprites.ImageStream = CType(resources.GetObject("Sprites.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Sprites.TransparentColor = System.Drawing.Color.Transparent
        Me.Sprites.Images.SetKeyName(0, "armor.chest..png")
        Me.Sprites.Images.SetKeyName(1, "armor.chest.A.png")
        Me.Sprites.Images.SetKeyName(2, "armor.chest.B.png")
        Me.Sprites.Images.SetKeyName(3, "armor.chest.C.png")
        Me.Sprites.Images.SetKeyName(4, "armor.chest.D.png")
        Me.Sprites.Images.SetKeyName(5, "armor.chest.E.png")
        Me.Sprites.Images.SetKeyName(6, "armor.chest.F.png")
        Me.Sprites.Images.SetKeyName(7, "armor.chest.G.png")
        Me.Sprites.Images.SetKeyName(8, "armor.chest.H.png")
        Me.Sprites.Images.SetKeyName(9, "armor.helmet.A.png")
        Me.Sprites.Images.SetKeyName(10, "armor.helmet.B.png")
        Me.Sprites.Images.SetKeyName(11, "armor.helmet.C.png")
        Me.Sprites.Images.SetKeyName(12, "armor.helmet.D.png")
        Me.Sprites.Images.SetKeyName(13, "armor.helmet.E.png")
        Me.Sprites.Images.SetKeyName(14, "armor.helmet.F.png")
        Me.Sprites.Images.SetKeyName(15, "armor.helmet.G.png")
        Me.Sprites.Images.SetKeyName(16, "armor.helmet.H.png")
        Me.Sprites.Images.SetKeyName(17, "armor.helmet.I.png")
        Me.Sprites.Images.SetKeyName(18, "armor.helmet.J.png")
        Me.Sprites.Images.SetKeyName(19, "armor.shield.A.png")
        Me.Sprites.Images.SetKeyName(20, "armor.shield.B.png")
        Me.Sprites.Images.SetKeyName(21, "armor.shield.C.png")
        Me.Sprites.Images.SetKeyName(22, "armor.shield.D.png")
        Me.Sprites.Images.SetKeyName(23, "armor.shield.E.png")
        Me.Sprites.Images.SetKeyName(24, "armor.shield.F.png")
        Me.Sprites.Images.SetKeyName(25, "armor.shield.G.png")
        Me.Sprites.Images.SetKeyName(26, "armor.shield.H.png")
        Me.Sprites.Images.SetKeyName(27, "armor.shield.I.png")
        Me.Sprites.Images.SetKeyName(28, "armor.shield.J.png")
        Me.Sprites.Images.SetKeyName(29, "armor.shield.K.png")
        Me.Sprites.Images.SetKeyName(30, "background.A.png")
        Me.Sprites.Images.SetKeyName(31, "background.B.png")
        Me.Sprites.Images.SetKeyName(32, "background.C.png")
        Me.Sprites.Images.SetKeyName(33, "char.normal.bow.png")
        Me.Sprites.Images.SetKeyName(34, "char.normal.empty.png")
        Me.Sprites.Images.SetKeyName(35, "char.other.A.png")
        Me.Sprites.Images.SetKeyName(36, "char.other.AA.png")
        Me.Sprites.Images.SetKeyName(37, "char.other.B.png")
        Me.Sprites.Images.SetKeyName(38, "char.other.BB.png")
        Me.Sprites.Images.SetKeyName(39, "char.other.C.png")
        Me.Sprites.Images.SetKeyName(40, "char.other.CC.png")
        Me.Sprites.Images.SetKeyName(41, "char.other.D.png")
        Me.Sprites.Images.SetKeyName(42, "char.other.DD.png")
        Me.Sprites.Images.SetKeyName(43, "char.other.E.png")
        Me.Sprites.Images.SetKeyName(44, "char.other.EE.png")
        Me.Sprites.Images.SetKeyName(45, "char.other.F.png")
        Me.Sprites.Images.SetKeyName(46, "char.other.FF.png")
        Me.Sprites.Images.SetKeyName(47, "char.other.G.png")
        Me.Sprites.Images.SetKeyName(48, "char.other.GG.png")
        Me.Sprites.Images.SetKeyName(49, "char.other.H.png")
        Me.Sprites.Images.SetKeyName(50, "char.other.HH.png")
        Me.Sprites.Images.SetKeyName(51, "char.other.I.png")
        Me.Sprites.Images.SetKeyName(52, "char.other.II.png")
        Me.Sprites.Images.SetKeyName(53, "char.other.J.png")
        Me.Sprites.Images.SetKeyName(54, "char.other.JJ.png")
        Me.Sprites.Images.SetKeyName(55, "char.other.K.png")
        Me.Sprites.Images.SetKeyName(56, "char.other.KK.png")
        Me.Sprites.Images.SetKeyName(57, "char.other.L.png")
        Me.Sprites.Images.SetKeyName(58, "char.other.M.png")
        Me.Sprites.Images.SetKeyName(59, "char.other.N.png")
        Me.Sprites.Images.SetKeyName(60, "char.other.O.png")
        Me.Sprites.Images.SetKeyName(61, "char.other.P.png")
        Me.Sprites.Images.SetKeyName(62, "char.other.Q.png")
        Me.Sprites.Images.SetKeyName(63, "char.other.R.png")
        Me.Sprites.Images.SetKeyName(64, "char.other.S.png")
        Me.Sprites.Images.SetKeyName(65, "char.other.T.png")
        Me.Sprites.Images.SetKeyName(66, "char.other.U.png")
        Me.Sprites.Images.SetKeyName(67, "char.other.V.png")
        Me.Sprites.Images.SetKeyName(68, "char.other.W.png")
        Me.Sprites.Images.SetKeyName(69, "char.other.X.png")
        Me.Sprites.Images.SetKeyName(70, "char.other.Y.png")
        Me.Sprites.Images.SetKeyName(71, "char.other.Z.png")
        Me.Sprites.Images.SetKeyName(72, "char.small.sword.png")
        Me.Sprites.Images.SetKeyName(73, "icon.active.arrow.png")
        Me.Sprites.Images.SetKeyName(74, "icon.active.fireball.png")
        Me.Sprites.Images.SetKeyName(75, "icon.active.fist.png")
        Me.Sprites.Images.SetKeyName(76, "icon.arrow.png")
        Me.Sprites.Images.SetKeyName(77, "icon.boost.png")
        Me.Sprites.Images.SetKeyName(78, "icon.boosted.png")
        Me.Sprites.Images.SetKeyName(79, "icon.close.png")
        Me.Sprites.Images.SetKeyName(80, "icon.cursor.hand.png")
        Me.Sprites.Images.SetKeyName(81, "icon.cursor.point.png")
        Me.Sprites.Images.SetKeyName(82, "icon.damage.png")
        Me.Sprites.Images.SetKeyName(83, "icon.directions.png")
        Me.Sprites.Images.SetKeyName(84, "icon.expand.png")
        Me.Sprites.Images.SetKeyName(85, "icon.fight.png")
        Me.Sprites.Images.SetKeyName(86, "icon.fireball.png")
        Me.Sprites.Images.SetKeyName(87, "icon.fist.png")
        Me.Sprites.Images.SetKeyName(88, "icon.health.0.png")
        Me.Sprites.Images.SetKeyName(89, "icon.health.25.png")
        Me.Sprites.Images.SetKeyName(90, "icon.health.50.png")
        Me.Sprites.Images.SetKeyName(91, "icon.health.75.png")
        Me.Sprites.Images.SetKeyName(92, "icon.health.100.png")
        Me.Sprites.Images.SetKeyName(93, "icon.heart.png")
        Me.Sprites.Images.SetKeyName(94, "icon.important.png")
        Me.Sprites.Images.SetKeyName(95, "icon.letters.AB.png")
        Me.Sprites.Images.SetKeyName(96, "icon.level.png")
        Me.Sprites.Images.SetKeyName(97, "icon.lightning.png")
        Me.Sprites.Images.SetKeyName(98, "icon.numbers.01.png")
        Me.Sprites.Images.SetKeyName(99, "icon.numbers.23.png")
        Me.Sprites.Images.SetKeyName(100, "icon.numbers.45.png")
        Me.Sprites.Images.SetKeyName(101, "icon.numbers.67.png")
        Me.Sprites.Images.SetKeyName(102, "icon.numbers.89.png")
        Me.Sprites.Images.SetKeyName(103, "icon.pulse.png")
        Me.Sprites.Images.SetKeyName(104, "icon.punctuation.png")
        Me.Sprites.Images.SetKeyName(105, "icon.question.png")
        Me.Sprites.Images.SetKeyName(106, "icon.resistance.png")
        Me.Sprites.Images.SetKeyName(107, "icon.scroll.png")
        Me.Sprites.Images.SetKeyName(108, "icon.selector.fancy.png")
        Me.Sprites.Images.SetKeyName(109, "icon.selector.png")
        Me.Sprites.Images.SetKeyName(110, "icon.shield.png")
        Me.Sprites.Images.SetKeyName(111, "icon.shirt.png")
        Me.Sprites.Images.SetKeyName(112, "icon.shots.png")
        Me.Sprites.Images.SetKeyName(113, "icon.skull.png")
        Me.Sprites.Images.SetKeyName(114, "icon.sleep.png")
        Me.Sprites.Images.SetKeyName(115, "icon.speech.png")
        Me.Sprites.Images.SetKeyName(116, "icon.sword.png")
        Me.Sprites.Images.SetKeyName(117, "icon.symbols.png")
        Me.Sprites.Images.SetKeyName(118, "icon.target.png")
        Me.Sprites.Images.SetKeyName(119, "icon.targeting.png")
        Me.Sprites.Images.SetKeyName(120, "icon.time.png")
        Me.Sprites.Images.SetKeyName(121, "item.arrow.big.png")
        Me.Sprites.Images.SetKeyName(122, "item.arrow.fast.png")
        Me.Sprites.Images.SetKeyName(123, "item.arrow.normal.png")
        Me.Sprites.Images.SetKeyName(124, "item.bag.png")
        Me.Sprites.Images.SetKeyName(125, "item.bones.png")
        Me.Sprites.Images.SetKeyName(126, "item.book.light.magic.A.png")
        Me.Sprites.Images.SetKeyName(127, "item.book.light.magic.B.png")
        Me.Sprites.Images.SetKeyName(128, "item.book.light.magic.C.png")
        Me.Sprites.Images.SetKeyName(129, "item.book.light.magic.D.png")
        Me.Sprites.Images.SetKeyName(130, "item.book.light.normal.png")
        Me.Sprites.Images.SetKeyName(131, "item.book.magic.A.png")
        Me.Sprites.Images.SetKeyName(132, "item.book.magic.B.png")
        Me.Sprites.Images.SetKeyName(133, "item.book.magic.C.png")
        Me.Sprites.Images.SetKeyName(134, "item.book.magic.D.png")
        Me.Sprites.Images.SetKeyName(135, "item.book.normal.png")
        Me.Sprites.Images.SetKeyName(136, "item.bottle.big.png")
        Me.Sprites.Images.SetKeyName(137, "item.bottle.medium.png")
        Me.Sprites.Images.SetKeyName(138, "item.bottle.small.png")
        Me.Sprites.Images.SetKeyName(139, "item.bow.long.png")
        Me.Sprites.Images.SetKeyName(140, "item.bow.medium.png")
        Me.Sprites.Images.SetKeyName(141, "item.bow.small.png")
        Me.Sprites.Images.SetKeyName(142, "item.chest.closed.png")
        Me.Sprites.Images.SetKeyName(143, "item.chest.open.png")
        Me.Sprites.Images.SetKeyName(144, "item.cresent.large.png")
        Me.Sprites.Images.SetKeyName(145, "item.cresent.medium.png")
        Me.Sprites.Images.SetKeyName(146, "item.cresent.small.png")
        Me.Sprites.Images.SetKeyName(147, "item.fire.png")
        Me.Sprites.Images.SetKeyName(148, "item.hammer.battle.png")
        Me.Sprites.Images.SetKeyName(149, "item.hammer.dark.png")
        Me.Sprites.Images.SetKeyName(150, "item.hammer.forge.png")
        Me.Sprites.Images.SetKeyName(151, "item.hammer.light.png")
        Me.Sprites.Images.SetKeyName(152, "item.hammer.mega.png")
        Me.Sprites.Images.SetKeyName(153, "item.hammer.short.png")
        Me.Sprites.Images.SetKeyName(154, "item.hammer.small.png")
        Me.Sprites.Images.SetKeyName(155, "item.hammer.swift.png")
        Me.Sprites.Images.SetKeyName(156, "item.hammer.tiny.png")
        Me.Sprites.Images.SetKeyName(157, "item.key.A.png")
        Me.Sprites.Images.SetKeyName(158, "item.key.B.png")
        Me.Sprites.Images.SetKeyName(159, "item.key.C.png")
        Me.Sprites.Images.SetKeyName(160, "item.key.D.png")
        Me.Sprites.Images.SetKeyName(161, "item.meat.png")
        Me.Sprites.Images.SetKeyName(162, "item.necklace.png")
        Me.Sprites.Images.SetKeyName(163, "item.pickaxe.png")
        Me.Sprites.Images.SetKeyName(164, "item.ring.big.png")
        Me.Sprites.Images.SetKeyName(165, "item.ring.png")
        Me.Sprites.Images.SetKeyName(166, "item.scroll.0.png")
        Me.Sprites.Images.SetKeyName(167, "item.scroll.1.png")
        Me.Sprites.Images.SetKeyName(168, "item.scroll.2.png")
        Me.Sprites.Images.SetKeyName(169, "item.scroll.3.png")
        Me.Sprites.Images.SetKeyName(170, "item.scroll.4.png")
        Me.Sprites.Images.SetKeyName(171, "item.scroll.5.png")
        Me.Sprites.Images.SetKeyName(172, "item.scroll.6.png")
        Me.Sprites.Images.SetKeyName(173, "item.scroll.7.png")
        Me.Sprites.Images.SetKeyName(174, "item.scroll.8.png")
        Me.Sprites.Images.SetKeyName(175, "item.scroll.9.png")
        Me.Sprites.Images.SetKeyName(176, "item.scroll.columns.png")
        Me.Sprites.Images.SetKeyName(177, "item.scroll.neat.png")
        Me.Sprites.Images.SetKeyName(178, "item.scroll.scribble.png")
        Me.Sprites.Images.SetKeyName(179, "item.scroll.smile.png")
        Me.Sprites.Images.SetKeyName(180, "item.scroll.square.png")
        Me.Sprites.Images.SetKeyName(181, "item.scroll.square2.png")
        Me.Sprites.Images.SetKeyName(182, "item.scroll.symbol.png")
        Me.Sprites.Images.SetKeyName(183, "item.scroll.time.png")
        Me.Sprites.Images.SetKeyName(184, "item.scroll.triangle.png")
        Me.Sprites.Images.SetKeyName(185, "item.scroll.x.png")
        Me.Sprites.Images.SetKeyName(186, "item.slingshot.png")
        Me.Sprites.Images.SetKeyName(187, "item.sword.big.png")
        Me.Sprites.Images.SetKeyName(188, "item.sword.dagger.png")
        Me.Sprites.Images.SetKeyName(189, "item.sword.knife.png")
        Me.Sprites.Images.SetKeyName(190, "item.sword.large.png")
        Me.Sprites.Images.SetKeyName(191, "item.sword.long.png")
        Me.Sprites.Images.SetKeyName(192, "item.sword.medium.png")
        Me.Sprites.Images.SetKeyName(193, "item.sword.mega.png")
        Me.Sprites.Images.SetKeyName(194, "item.sword.normal.png")
        Me.Sprites.Images.SetKeyName(195, "item.sword.short.png")
        Me.Sprites.Images.SetKeyName(196, "item.sword.thick.png")
        Me.Sprites.Images.SetKeyName(197, "obj.barrel.png")
        Me.Sprites.Images.SetKeyName(198, "obj.bed.png")
        Me.Sprites.Images.SetKeyName(199, "obj.bridge.png")
        Me.Sprites.Images.SetKeyName(200, "obj.door.blocked.png")
        Me.Sprites.Images.SetKeyName(201, "obj.door.castle.closed.png")
        Me.Sprites.Images.SetKeyName(202, "obj.door.castle.open.png")
        Me.Sprites.Images.SetKeyName(203, "obj.door.double.closed.png")
        Me.Sprites.Images.SetKeyName(204, "obj.door.double.open.png")
        Me.Sprites.Images.SetKeyName(205, "obj.door.dungeon.png")
        Me.Sprites.Images.SetKeyName(206, "obj.door.normal.closed.png")
        Me.Sprites.Images.SetKeyName(207, "obj.door.normal.open.png")
        Me.Sprites.Images.SetKeyName(208, "obj.door.trap.closed.png")
        Me.Sprites.Images.SetKeyName(209, "obj.door.trap.open.png")
        Me.Sprites.Images.SetKeyName(210, "obj.floor.carpet.png")
        Me.Sprites.Images.SetKeyName(211, "obj.floor.carpetBig.dark.bl.png")
        Me.Sprites.Images.SetKeyName(212, "obj.floor.carpetBig.dark.br.png")
        Me.Sprites.Images.SetKeyName(213, "obj.floor.carpetBig.dark.center.png")
        Me.Sprites.Images.SetKeyName(214, "obj.floor.carpetBig.dark.shaggy.png")
        Me.Sprites.Images.SetKeyName(215, "obj.floor.carpetBig.dark.side.png")
        Me.Sprites.Images.SetKeyName(216, "obj.floor.carpetBig.dark.tl.png")
        Me.Sprites.Images.SetKeyName(217, "obj.floor.carpetBig.dark.tr.png")
        Me.Sprites.Images.SetKeyName(218, "obj.floor.carpetBig.light.bl.png")
        Me.Sprites.Images.SetKeyName(219, "obj.floor.carpetBig.light.br.png")
        Me.Sprites.Images.SetKeyName(220, "obj.floor.carpetBig.light.shaggy.png")
        Me.Sprites.Images.SetKeyName(221, "obj.floor.carpetBig.light.side.png")
        Me.Sprites.Images.SetKeyName(222, "obj.floor.carpetBig.light.tl.png")
        Me.Sprites.Images.SetKeyName(223, "obj.floor.carpetBig.light.tr.png")
        Me.Sprites.Images.SetKeyName(224, "obj.floor.carpetWood.png")
        Me.Sprites.Images.SetKeyName(225, "obj.floor.crack.png")
        Me.Sprites.Images.SetKeyName(226, "obj.floor.poles.png")
        Me.Sprites.Images.SetKeyName(227, "obj.floor.rocks.png")
        Me.Sprites.Images.SetKeyName(228, "obj.floor.rocks.sharp.png")
        Me.Sprites.Images.SetKeyName(229, "obj.floor.spikes.png")
        Me.Sprites.Images.SetKeyName(230, "obj.floor.stair.png")
        Me.Sprites.Images.SetKeyName(231, "obj.floor.stone.png")
        Me.Sprites.Images.SetKeyName(232, "obj.floor.stoneEdge.png")
        Me.Sprites.Images.SetKeyName(233, "obj.floor.swamp.B.png")
        Me.Sprites.Images.SetKeyName(234, "obj.floor.swamp.png")
        Me.Sprites.Images.SetKeyName(235, "obj.floor.tile.center.dark.png")
        Me.Sprites.Images.SetKeyName(236, "obj.floor.tile.center.light.png")
        Me.Sprites.Images.SetKeyName(237, "obj.floor.tile.dark.png")
        Me.Sprites.Images.SetKeyName(238, "obj.floor.tile.fancy.png")
        Me.Sprites.Images.SetKeyName(239, "obj.floor.tile.light.png")
        Me.Sprites.Images.SetKeyName(240, "obj.floor.water.boat.png")
        Me.Sprites.Images.SetKeyName(241, "obj.floor.water.full.png")
        Me.Sprites.Images.SetKeyName(242, "obj.floor.water.half.png")
        Me.Sprites.Images.SetKeyName(243, "obj.floor.water.swirl.png")
        Me.Sprites.Images.SetKeyName(244, "obj.floor.wood.png")
        Me.Sprites.Images.SetKeyName(245, "obj.floor.woodFancy.png")
        Me.Sprites.Images.SetKeyName(246, "obj.rock.round.png")
        Me.Sprites.Images.SetKeyName(247, "obj.rocks.png")
        Me.Sprites.Images.SetKeyName(248, "obj.sign.png")
        Me.Sprites.Images.SetKeyName(249, "obj.small.castle.png")
        Me.Sprites.Images.SetKeyName(250, "obj.small.house.cross.png")
        Me.Sprites.Images.SetKeyName(251, "obj.small.house.line.png")
        Me.Sprites.Images.SetKeyName(252, "obj.small.house.png")
        Me.Sprites.Images.SetKeyName(253, "obj.small.keep.png")
        Me.Sprites.Images.SetKeyName(254, "obj.small.volcano.png")
        Me.Sprites.Images.SetKeyName(255, "obj.spike.png")
        Me.Sprites.Images.SetKeyName(256, "obj.stairs.down.png")
        Me.Sprites.Images.SetKeyName(257, "obj.stairs.up.png")
        Me.Sprites.Images.SetKeyName(258, "obj.store.small.png")
        Me.Sprites.Images.SetKeyName(259, "obj.table.png")
        Me.Sprites.Images.SetKeyName(260, "obj.tombstone.png")
        Me.Sprites.Images.SetKeyName(261, "obj.tree.dead.png")
        Me.Sprites.Images.SetKeyName(262, "obj.tree.png")
        Me.Sprites.Images.SetKeyName(263, "obj.wall.bookshelf.png")
        Me.Sprites.Images.SetKeyName(264, "obj.wall.door.close.png")
        Me.Sprites.Images.SetKeyName(265, "obj.wall.door.open.png")
        Me.Sprites.Images.SetKeyName(266, "obj.wall.door.stairway.png")
        Me.Sprites.Images.SetKeyName(267, "obj.wall.thick.corner.bl.png")
        Me.Sprites.Images.SetKeyName(268, "obj.wall.thick.corner.br.png")
        Me.Sprites.Images.SetKeyName(269, "obj.wall.thick.corner.tl.png")
        Me.Sprites.Images.SetKeyName(270, "obj.wall.thick.corner.tr.png")
        Me.Sprites.Images.SetKeyName(271, "obj.wall.thick.horizontal.center.png")
        Me.Sprites.Images.SetKeyName(272, "obj.wall.thick.horizontal.left.png")
        Me.Sprites.Images.SetKeyName(273, "obj.wall.thick.horizontal.right.png")
        Me.Sprites.Images.SetKeyName(274, "obj.wall.thick.pillar.png")
        Me.Sprites.Images.SetKeyName(275, "obj.wall.thick.vertical.left.png")
        Me.Sprites.Images.SetKeyName(276, "obj.wall.thick.vertical.left2.png")
        Me.Sprites.Images.SetKeyName(277, "obj.wall.thick.vertical.r.png")
        Me.Sprites.Images.SetKeyName(278, "obj.wall.thick.vertical.right2.png")
        '
        'Draw
        '
        Me.Draw.Interval = 1
        '
        'CenterPanel1
        '
        Me.CenterPanel1.BackColor = System.Drawing.Color.Transparent
        Me.CenterPanel1.Controls.Add(Me.Viewport1)
        Me.CenterPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CenterPanel1.Location = New System.Drawing.Point(0, 0)
        Me.CenterPanel1.Name = "CenterPanel1"
        Me.CenterPanel1.Size = New System.Drawing.Size(982, 472)
        Me.CenterPanel1.TabIndex = 0
        '
        'Viewport1
        '
        Me.Viewport1.BackColor = System.Drawing.Color.Black
        Me.Viewport1.Location = New System.Drawing.Point(255, 0)
        Me.Viewport1.Name = "Viewport1"
        Me.Viewport1.Size = New System.Drawing.Size(472, 472)
        Me.Viewport1.TabIndex = 0
        '
        'Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.[Byte].My.Resources.Resources.background_large_C
        Me.ClientSize = New System.Drawing.Size(982, 472)
        Me.Controls.Add(Me.CenterPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Window"
        Me.Text = "Byte"
        Me.CenterPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Sprites As System.Windows.Forms.ImageList
    Friend WithEvents Draw As System.Windows.Forms.Timer
    Friend WithEvents CenterPanel1 As [Byte].CenterPanel
    Friend WithEvents Viewport1 As [Byte].Viewport

End Class
