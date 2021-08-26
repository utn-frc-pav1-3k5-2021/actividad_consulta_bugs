



# BugTracker - Actividad Consulta Bugs


## 1. Clonar Repositorio (Clone/Checkout)

**1.1. Ejecutar comando clone para descargar repositorio:** 
```sh
$ git clone https://github.com/utn-frc-pav1-3k5-2021/actividad_consulta_bugs
```
**1.2. Ubicarse en la carpeta generada con el nombre del repositorio: 

```sh
$ cd actividad_consulta_bugs
```

**1.3. Crear un nuevo branch (rama)**

Para crear una nueva rama (branch) y saltar a ella, en un solo paso, puedes utilizar el comando  `git checkout`  con la opción  `-b`, indicando el nombre del nuevo branch (reemplazando el nro de legajo) de la siguiente forma branch_{legajo}, para el legajo 12345:

```sh
$ git checkout -b branch_12345 
Switched to a new branch "12345"
```
Y para que se vea reflejada en GitHub:
```sh
$ git push --set-upstream origin branch_12345
```

## 2. Ejecutar Script Base de datos
**2.1. Iniciar la aplicación `Sql Server Management Studio`**

Solicitará ingresar los datos de la base de datos para generar una conexión, completar los datos y hacer click en **Connect**. Los datos del servidor del labsis son:

 - **Tipo Servidor:** Database Engine
 - **Nombre Servidor:** .\SQLEXPRESS
 - **Autenticación:** Windows Authentication.
 
 
 **2.2. Abrir archivo `BugTracker_Crear_BaseDatos.sql`**
 Ir a la opción `Archivo -> Abrir -> Archivo` (o combinación de teclas `Ctrl + O`) y buscar el archivo BugTracker_Crear_BaseDatos.sql en el disco local.
  

**2.5. Ejecutar Script** 
Para ejecutar el script hacer click sobre el botón `Ejecutar` (o usar la tecla `F5`)


## 3. Actividad: Menú de Opciones

> En la clase DataManager.cs cambiar la cadena de conexión según corresponda:
- Ejemplo de cadena de conexión a través de windows:
	- Data Source=.\\SQLEXPRESS;Initial Catalog=BugTracker;Integrated Security=true;
	


1. Agregar al menú **Consultar Bugs** de **frmPrincipal**, el evento **Click()** para abrir el formulario **frmConsultaBugs**   
```csharp

        private void consultarBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBugs frmDetalle = new frmConsultaBugs();
            frmDetalle.ShowDialog();
        }
```

2. Agregar al menú **Salir** de **frmPrincipal**,  el evento **Click()** que ejecute el cierre de la aplicación.

```csharp
	    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

```


## 4. Actividad: Filtros de Busqueda - ConsultaBugs

1 En la clase **frmConsultaBugs** agregar el método LlenarCombo, para generalizar lógica que completa los ComboBox con datos para que luego pueden ser seleccionados por el usuario:

```csharp
	private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
	        // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
        }
```
2. Agregar al formulario el evento **Load()** (que se dispara al abrir el formulario), y en dicho evento se procederá a cargar los combos de la siguiente forma:
```csharp
        private void frmBugs_Load(object sender, EventArgs e)
        {
		
            LlenarCombo(cboEstados, DataManager.GetInstance().ConsultaSQL("Select * from Estados"), "nombre", "id_estado");

            LlenarCombo(cboPrioridades, DataManager.GetInstance().ConsultaSQL("Select * from Prioridades"), "nombre", "id_prioridad");

            LlenarCombo(cboCriticidades, DataManager.GetInstance().ConsultaSQL("Select * from Criticidades"), "nombre", "id_criticidad");

            LlenarCombo(cboAsignadoA, DataManager.GetInstance().ConsultaSQL("Select * from Usuarios"), "usuario", "id_usuario");

            LlenarCombo(cboProductos, DataManager.GetInstance().ConsultaSQL("Select * from Productos"), "nombre", "id_producto");

        }
```
## 5. Actividad: Consultar Bugs

1. Agregar al botón **Consultar** el evento **Click()**, para que construya la consulta sql que busque los bugs registrados en la base de datos, con los filtros cargados en el formulario:

> Clase **Dictionary<TKey,TValue>**: Representa una colección de claves (TKey) y valores (TValue).

```csharp
	private void btnConsultar_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT TOP 20 * FROM bugs WHERE 1=1 ";
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            DateTime fechaDesde;
            DateTime fechaHasta;
            if (DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) &&
                DateTime.TryParse(txtFechaHasta.Text, out fechaHasta))
            {
                strSql += " AND (fecha_alta>=@fechaDesde AND fecha_alta<=@fechaHasta) ";
                parametros.Add("fechaDesde", txtFechaDesde.Text);
                parametros.Add("fechaHasta", txtFechaHasta.Text);
            }


            if (!string.IsNullOrEmpty(cboEstados.Text))
            {
                var idEstado = cboEstados.SelectedValue.ToString();
                strSql += "AND (id_estado=@idEstado) ";
                parametros.Add("idEstado", idEstado);
            }

            if (!string.IsNullOrEmpty(cboAsignadoA.Text))
            {
                var asignadoA = cboAsignadoA.SelectedValue.ToString();
                strSql += "AND (id_usuario_asignado=@idUsuarioAsignado) ";
                parametros.Add("idUsuarioAsignado", asignadoA);
            }

            //Completar el resto de las validaciones

            strSql += " ORDER BY fecha_alta DESC";
            dgvBugs.DataSource = DataManager.GetInstance().ConsultaSQL(strSql, parametros);
			
            if (dgvBugs.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
```

## 6. Versionar los cambios locales (add / commit / push)

> A continuación vamos a crear el **commit** y subir los cambios al servidor GitHub.

1. **Status**. Verificamos los cambios pendientes de versionar.

```sh
$ git status
```

2. **Add** Agregamos todos los archivos nuevos no versionados.

```sh
$ git add -A
```

3. **Commit** Generamos un commit con todos los cambios y agregamos un comentario.

```sh
$ git commit -a -m "Comentario"
```

4. **Push** Enviamos todos los commits locales a GitHub

```sh
$ git push
```

5. **Status** Verificar que no quedaron cambios pendientes de versionar

```sh
$ git status
```

