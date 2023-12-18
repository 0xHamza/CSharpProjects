Bu dosya proje hakkında açıklama yapan readme dosyasıdır.


Bu proje tabcontrol sekme seçim alanlarını gizlenmesini sağlayan bir uygulamadır.
Bu sayede üstte görünen sekmeleri gizleyerek daha şık bir görünüm elde edilmiştir.

Bu proje C# programlama dili ile yazılmıştır.


Sekme seçim alanlarını gizlemek için aşağıdaki kodu FormLoad aşamasında veya özellik penceresinden değiştirerek kullanabilirsiniz.

```csharp
tabControl1.Appearance = TabAppearance.FlatButtons;
tabControl1.ItemSize = new Size(0, 1);
tabControl1.SizeMode = TabSizeMode.Fixed;
```

Eğer tabcontrolunuzun bütün formu kaplamasını istiyorsanız aşağıdaki kodu veya özellik penceresinden değiştirerek kullanabilirsiniz.

```csharp
tabControl1.Dock = DockStyle.Fill;
```

Sekme seçim alanlarını göstermek için aşağıdaki kodu kullanabilirsiniz.

```csharp
tabControl1.Appearance = TabAppearance.Normal;
tabControl1.ItemSize = new Size(0, 0);
tabControl1.SizeMode = TabSizeMode.Normal;
```

Sekmeler arasında geçiş yapmak için aşağıdaki kodu kullanabilirsiniz.

```csharp
tabControl1.SelectedIndex = 0;

//veya

tabControl1.SelectedTab = tabControl1.TabPages[0]; //0. index 1. tabpage veya 1. index 2. tabpage
```

veya

```csharp
tabControl1.SelectedTab = tabPage2;

//veya

tabControl1.SelectTab(tabPage1);

//veya

tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];  //name özelliği ile 2. tabpage'e geçiş yaparız.
```


