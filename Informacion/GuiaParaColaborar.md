# Guía para colaborar en el proyecto de GitHub

Te he agregado como colaborador del repositorio. Para poder trabajar en el proyecto, sigue estos pasos:

## 1. Crear una cuenta de GitHub

Si aún no tienes una cuenta, regístrate en:

https://github.com

Una vez creada, envíame tu nombre de usuario para poder agregarte al repositorio.

---

## 2. Aceptar la invitación

Cuando te agregue como colaborador:

1. Inicia sesión en GitHub.
2. Revisa tus notificaciones o tu correo electrónico.
3. Busca la invitación al repositorio.
4. Haz clic en **Accept Invitation**.

Después de aceptarla, tendrás acceso para ver y modificar el proyecto.

---

## 3. Instalar Git

Descarga e instala Git desde:

https://git-scm.com/downloads

Durante la instalación puedes dejar las opciones predeterminadas.

Para verificar que quedó instalado, abre una terminal y escribe:

```bash
git --version
```

---

## 4. Clonar el repositorio

Abre Git Bash o la terminal y ve a la carpeta donde quieras guardar el proyecto.

Luego ejecuta:

```bash
git clone URL_DEL_REPOSITORIO
```

Ejemplo:

```bash
git clone https://github.com/usuario/proyecto.git
```

Esto descargará una copia completa del proyecto en tu computadora.

---

## 5. Abrir el proyecto

Entra a la carpeta creada:

```bash
cd nombre-del-proyecto
```

Abre el proyecto con el programa correspondiente (Visual Studio, VS Code, Godot, etc.).

---

## 6. Actualizar antes de trabajar

Antes de comenzar cualquier modificación, descarga los cambios más recientes:

```bash
git pull origin main
```

Así evitarás trabajar sobre una versión antigua.

---

## 7. Realizar cambios

Puedes:

* Crear archivos nuevos.
* Modificar archivos existentes.
* Eliminar archivos que ya no se necesiten.

Guarda todos los cambios realizados.

---

## 8. Preparar los cambios

En la terminal, dentro de la carpeta del proyecto:

```bash
git add .
```

Este comando agrega todos los cambios para ser guardados.

---

## 9. Crear un commit

Describe brevemente lo que hiciste:

```bash
git commit -m "Descripción de los cambios"
```

Ejemplos:

```bash
git commit -m "Agregado menú principal"
```

```bash
git commit -m "Corregidos errores de movimiento"
```

---

## 10. Subir los cambios a GitHub

Envía los cambios al repositorio:

```bash
git push origin main
```

Los cambios quedarán disponibles para todos los colaboradores.

---

## 11. Recomendaciones importantes

Antes de empezar a trabajar:

```bash
git pull origin main
```

Después de terminar:

```bash
git add .
git commit -m "Descripción de los cambios"
git push origin main
```

Si otra persona modificó los mismos archivos, Git puede solicitar resolver conflictos antes de subir los cambios.

---

## Flujo de trabajo resumido

Cada vez que trabajes en el proyecto:

```bash
git pull origin main
```

Realiza tus modificaciones.

```bash
git add .
git commit -m "Descripción de los cambios"
git push origin main
```

Con eso tus cambios quedarán sincronizados en el repositorio compartido.
