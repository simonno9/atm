   M S B A M L   `   `   `  ????M  Igeldautomaat admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:geldautomaat_admingeldautomaat_admin  5   	   #    geldautomaat_admin.UserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:geldautomaat_admin     5   	     ? Title$  
UserWindow??5   	   $	??650??6   $
??1000??6)   .??5
      ? 
???OO/? ? RowDefinitions 5   
   ?? 5      $	??34* ?6   6+   ?? 5      $	??34* ?6   6+   ?? 5      $	??34* ?6   6+   ?? 5      $	??34* ?6   6+   ?? 5      $	??34* ?6   6+   ?? 5      $	??34* ?6   6+   ?? 5      $	??34* ?6   6+    ? ColumnDefinitions 5   
   ?? 5      $
??142* ?6   ?? 5      $
??141* ?6   ?? 5      $
??235* ?6   ?? 5      $
??141* ?6   ?? 5      $
??141* ?6   ?? 5      $
??141* ?6   .+?5   
   ?? $??1??6   $??4??6%   $??1??69   $??5??6F   
???????
????  ?$??2??6w   &   System.Windows.Controls.DataGrid  5!   
   -   5        $??dgUsers??5!         AutoGenerateColumns .  $??Center=?5"   *   $	??Top=?5#   ,   $   HorizontalScrollBarVisibility$ Disabled=?5$   *   $??2??5%   *   $??1??69   $??4??6I   $??3??6^    J? OpacityMask
 ?????
???????$??0q?5(   *      CanUserResizeRows .     CanUserAddRows .  ??5)   *   ??  ?? Path$ LoadDataBinding?	   Columns	 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn
   Header$
 user__id??6F      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6X      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? $ user_id?6c     5.      $
 voornaam??6G   $	 147 6Y    .  6%   ?? $ voornaam?6e     5/      $
 
achternaam??6I   $	 147 6]    .  6%   ?? $ 
achternaam?6i   4  .System.Windows.Controls.DataGridTemplateColumn  51      $ 80 6)      CellTemplate 52      ?? 53      .R?54      ?? -   5        $??
rekeningen??54   %   $??80??6U   55      57      59      ?? 5:   
   -   5        $??searchTextBox??5:   &    ?? TextWrapping$
 Wrap=?6   $?? ??6;   $??30??6C   $??2??6O   $??1??6_   $??134,27,137,23q?6l   
????  ?$??2q?6?   $??2??6?   ?? 5;   
   -   5        $??backBtn??5;      $??logout??6    $??1??61   $??5??6A   $	??100??6N   $??50??6Z   ?? 5<   
   -   5        $??	BtnCreate??5<      $??create??6"   $??4??63   $??5??6C   $	??100??6P   $??50??6\   ?? 5=   
   -   5        $??	btnSearch??5=      $??search??6"   $??1??64   $??80??6A   $??30??6L   $??103,31,117,29q?6X   $??3??6o   $??2??6   ?? 5>   
   -   5         ??Name$ btnReset??5>      $??reset??6#   $??1??64   $??80??6A   $??30??6L   $??18,31,52,29q?6X   $??3??6m   5@      5A      