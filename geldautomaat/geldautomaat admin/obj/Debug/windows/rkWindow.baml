   M S B A M L   `   `   `  ????M  Igeldautomaat admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:geldautomaat_admin.windowsgeldautomaat_admin.windows  5   	   )    #geldautomaat_admin.windows.rkWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:geldautomaat_admin.windows     5   	     ? Title$  rkWindow??5   	   $	??650??6   $
??1000??6(   .??5
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
   -   5        $??dgRekeningen??5!         AutoGenerateColumns .  $??Center=?5"   *   $	??Top=?5#   ,   $   HorizontalScrollBarVisibility$ Disabled=?5$   *   $??2??5%   *   $??1??69   $??4??6I   $??3??6]    J? OpacityMask
 ?????
???????$??0q?5(   *      CanUserResizeRows .     CanUserAddRows .  ??5)   *   ??  ?? Path$ LoadDataBinding?	   Columns	 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn
   Header$
 rekening__id??6J      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6`      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? $ rekening_id?6k     5.      $
 rekeningnummer??6N   $	 110 6f    .  6%   ?? $ rekeningsnummer?6r     5/      $
 saldo??6D   $ 70 6S    .  6%   ?? $ saldo?6^     50      $
 pincode??6F   $ 75 6W    .  6%   ?? $ pincode?6b     51      $
 status??6E   $ 75 6U    .  6%   ?? $ status?6`   4  .System.Windows.Controls.DataGridTemplateColumn  52      $ 80 6)      CellTemplate 53      ?? 54      .R?55      ?? -   5        $??Deblokkeren??55   %   $??80??6R   56      58        59      $ 80 6)    5:      ?? 5;      .R?5<      ?? -   5        $??	blokkeren??5<   %   $??80??6N   5=      5?      5B      ?? 5C   
   -   5        $??searchTextBox??5C   4    ?? TextWrapping$
 Wrap=?6   $??search??6&   $??40??6I   $??2??6U   $??1??6e   $??248,27,4,23q?6r   
????  ?$??2q?6?   $??2??6?   ?? 5D   
   -   5        $??backBtn??5D      $
??back??6    $??1??6/   $??5??6?   $	??100??6L   $??50??6X   ?? 5E   
   -   5        $??	BtnCreate??5E      $??create??6"   $??4??63   $??5??6C   $	??100??6P   $??50??6\   5G      5H      