   M S B A M L   `   `   `  ????I  EVelvetEyebrows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:VelvetEyebrows.ViewsVelvetEyebrows.Views  5      +    %VelvetEyebrows.Views.RegistrationPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:VelvetEyebrows.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N? Title$$  Запись на услугу??5	      $	??505??6    .??5      ?? .+?5   
   ?? $$??Запись на услугу??6   $??35(?6+   $??0 0 0 25q?69   ?? 5   
   $??10q?6   .+?5      ?? $??Клиент??6   ?? 5      -   5         ??Name$ clientsComboBox??5      ??60   ?? *	Clients+ ?? SelectedItem 6P   ?? *Client+??5      ?? 5      .R?5      ?? ?? 5      ?6"   ?? *
LastName+ ?? 5      ?6"   ?? *	FirstName+5      5      5      ?? 5      $??Услуга??6   ?? 5      ??6   ?? *
Services+ 68   ?? *	Service+??5      ?? 5      .R?5      ?? ?? 5      ?6"   ?? *Title+ | ?? 5       ?6"   ?? *CostWithDiscount+ ?? Mode$ OneWay=? ?? StringFormat$ {0:0.00}??
 р. за ?? 5!      ?6"   ?? *DurationInMunites+$ OneWay=?
 мин.5"      5#      5%      ?? 5&      $??Дата записи??6   (  "System.Windows.Controls.DatePicker  5'      -   5          Name$ serviceDatePicker??5'         IsTodayHighlighted$
 True??64   ?? 5(      $??Время записи??6   )  #MaterialDesignThemes.Wpf.TimePicker  5)      -   5          Name$ serviceTimePicker??5)   9      	Is24Hours$
 True??6(   69   ?? 5*      $??Комментарий??6   ?? 5+      -   5        	 ??Name$	 commentTextBox??5+   ?   $??Visible=?6    !  MaterialDesignOutlinedTextBox#???   6I   
 ?? TextWrapping$

 Wrap=?6?    ?? AcceptsReturn$
 True??6?   ??6?   ?? *ClientService.Comment+6?   ?? 5,      -   5        $
??0 20q?5,   *   $??Записать??68    ? Cursor$
 Hand??6K   ?? 5-      -   5        $	??0 0q?5-      $??
Назад??6"    ?? IsCancel$
 True??6B   $
 Hand??6R   5.      5/      50      