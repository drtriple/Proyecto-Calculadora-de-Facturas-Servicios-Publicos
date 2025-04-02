// Variable global con la URL base de la API
var dir = "http://localhost:59300/api/";

/**
 * Inicializa la página ocultando la tabla.
 */
document.addEventListener("DOMContentLoaded", function () {
    toggleTablaVisibilidad();
});

/**
 * Función para alternar la visibilidad de la tabla.
 */
function toggleTablaVisibilidad() {
    const tabla = document.getElementById("tablaResultados");
    if (tabla) {
        // Opción 1: Usando visibility
        if (tabla.style.visibility === "hidden" || getComputedStyle(tabla).visibility === "hidden") {
            tabla.style.visibility = "visible";
            tabla.style.height = "auto"; // Recuperar el espacio
        } else {
            tabla.style.visibility = "hidden";
            tabla.style.height = "0"; // Para que no ocupe espacio
        }

        // Enfocar el campo de texto después de alternar
        document.getElementById("txtVrDolar").focus();
    } else {
        console.error("No se encontró el elemento tablaResultados");
    }
}

/**
 * Procesa la información ingresada y envía una petición POST a la API.
 * Obtiene los valores ingresados en el formulario, los envía a la API y muestra los resultados en la tabla.
 */
document.getElementById("btnProcesar").addEventListener("click", async function () {
    try {
        const data = {
            Estrato: parseInt(document.getElementById("cmbEst").value),
            kKw: parseFloat(document.getElementById("txtKvh").value) || 0,
            kM3: parseFloat(document.getElementById("txtKm3").value) || 0,
            klTel: parseFloat(document.getElementById("txtKit").value) || 0,
            vrDolar: parseFloat(document.getElementById("txtVrDolar").value) || 0
        };

        console.log("Enviando datos a API:", data); // Para depuración

        const response = await fetch(`${dir}sSerPub`, {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(data)
        });

        if (!response.ok) {
            throw new Error(`Error en la API: ${response.status}`);
        }

        const result = await response.json();
        console.log("Respuesta de la API:", result); // Para depuración

        if (result.Error) {
            alert("Error: " + result.Error);
        } else {
            mostrarResultados(result);
        }
    } catch (error) {
        console.error("Error en btnProcesar:", error);
        alert("Error de conexión: " + error.message);
    }
});

/**
 * Muestra los resultados en la tabla y la hace visible.
 * @param {Object} result - Datos devueltos por la API.
 */
function mostrarResultados(result) {
    try {
        document.getElementById("txtTEner").value = result.vrTEnergia;
        document.getElementById("txtCEner").value = result.vrKw;
        document.getElementById("txtTAgua").value = result.vrTAgua;
        document.getElementById("txtCAgua").value = result.vrM3;
        document.getElementById("txtTTel").value = result.vrTTelef;
        document.getElementById("txtCTel").value = result.vrTel;
        document.getElementById("txtimpC").value = result.vrImpCons;

        // Formateo de Total a Pagar en formato colombiano
        document.getElementById("txtAPagar").value = new Intl.NumberFormat("es-CO", {
            style: "currency",
            currency: "COP",
            minimumFractionDigits: 2,
            maximumFractionDigits: 2
        }).format(result.vrAPag);

        // Mostrar la tabla
        toggleTablaVisibilidad();
    } catch (error) {
        console.error("Error en mostrarResultados:", error);
    }
}

/**
 * Limpia los campos del formulario y oculta la tabla.
 */
document.getElementById("btnLimpiar").addEventListener("click", function () {
    try {
        document.getElementById("formLiquidacion").reset();

        document.querySelectorAll("input[readonly]").forEach(input => input.value = "");

        toggleTablaVisibilidad();
    } catch (error) {
        console.error("Error en btnLimpiar:", error);
    }
});