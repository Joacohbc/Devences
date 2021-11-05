using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Logica
{
    public class Validaciones
    {
        #region Metodos de limpieza de campos
        /// <summary>
        /// Busca los TextBox de un Form y devuelve True si alguno tiene texto
        /// </summary>
        /// <param name="formEntrante">El Form</param>
        /// <returns> True si alguno tiene texto, False si todos estan vacios</returns>
        public bool hayAlgo(Form formEntrante)
        {
            //Que tome todos los TextBoxes del Fomr
            foreach (TextBox t in formEntrante.Controls.OfType<TextBox>())
            {
                //Si no estan vacio que retorne true 
                if (!String.IsNullOrWhiteSpace(t.Text))
                {
                    //Retorna true, sigmifica que si hay un TextBox con texto
                    return true;
                }
            }

            //Si no hay ninguno con texto retorna false
            return false;
        }

        /// <summary>
        /// "Limpia" los componentes de un array de controles y le da el focus al primero
        /// </summary>
        /// <param name="controles"> el form</param>
        public void limpiarControles(Control[] controles)
        {
            //Si no esta vacio
            if (controles.Length > 0)
            {
                //Lista todos los controles del array
                foreach (Control c in controles)
                {
                    //Si es TextBox
                    if (c is TextBox)
                    {
                        //Lo limpia
                        ((TextBox)c).Clear();
                    }
                    //Si es un DatePicker
                    else if (c is DateTimePicker)
                    {
                        //Y lo setea en el dia de hoy
                        ((DateTimePicker)c).Value = DateTime.Parse(DateTime.Now.ToShortDateString());
                    }
                    //Si es un RadioButton
                    else if (c is RadioButton)
                    {
                        //Lo descheckea
                        ((RadioButton)c).Checked = false;
                    }
                    //Si es CheckBox
                    else if (c is CheckBox)
                    {
                        //Lo deschekea
                        ((CheckBox)c).Checked = false;
                    }
                    //Si es DataGrid
                    else if (c is DataGridView)
                    {
                        //Borra todas sus filas
                        ((DataGridView)c).Rows.Clear();
                    }
                    //Si es un ListBox
                    else if (c is ListBox)
                    {
                        //Borra todas sus filas
                        ((ListBox)c).Items.Clear();
                    }

                    //Le doy focus al primero
                    controles[0].Focus();
                }
            }
        }
        #endregion

        #region Metodos de validacion de caracteres
        /// <summary>
        /// Se encarga de validar si el caracter ingresado se encuentra en las excepciones
        /// </summary>
        /// <param name="ingreso"> el caracter qeu se quiere validar en las excepciones </param>
        /// <param name="excepciones">Excepciones, deben ir separadas con espacios </param>
        /// <returns> si es valido o no el caracter </returns>
        private bool validarExcepciones(Char ingreso, String excepciones)
        {
            //Separa por espacios el string y lo cobierte en array
            //Y lo recorre
            foreach (String c in excepciones.Split(' '))
            {
                //Comprueba si el char ingresado esta
                //dentro del array de exepciones
                if (ingreso == Char.Parse(c))
                {
                    //Si es igual algun caracter dentro del array de expeciones
                    //Retorna true
                    return true;
                }
            }
            
            //Si no esta dentro retorna false
            return false;
        }

        /// <summary>
        /// Valida el caracter permitiendo tanto Digitos como Letras, permite/deniega el uso
        /// de espacios y permite un listado de excepciones
        /// </summary>
        /// <param name="c">un caracter(Char)</param>
        /// <param name="espacios">Bool que si es True permite espacios, si es False los deneiga</param>
        /// <param name="excepciones">El listado de caracteres que no se tome como digitos o letras pero
        /// que sean validos para el ingreso </param>
        /// <returns> Retorna si el Caracter cumple con lo pedido o si no lo cumple</returns>
        public bool validarSiCaracterEsDigitoLetra(Char c, bool espacios, String excepciones)
        {
            //Si excepcion esta vacio, no hay que tenerlas encuenta
            //Sino, no las tiene en cuenta
            if (String.IsNullOrWhiteSpace(excepciones))//Letras y digitos
            {
                if (char.IsLetterOrDigit(c))
                {
                    return true;
                }
                //Para el Backspace(borrar)
                else if (char.IsControl(c))
                {
                    return true;
                }
                //Si los espacios estan activados
                //Comprueba que sea un espacio
                //Sino ni lo toma en cuenta(va al else)
                else if (espacios && (c == ' '))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else//Letras, digitos y perzonalisado
            {
                if (char.IsLetterOrDigit(c))
                {
                    return true;
                }
                else if (char.IsControl(c))
                {
                    return true;
                }
                else if (espacios && (c == ' '))
                {
                    return true;
                }
                //Si esta dentro de las expeciones
                else if (validarExcepciones(c, excepciones))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Valida el caracter permitiendo solo Letras, permite/deniega el uso
        /// de espacios y permite un listado de excepciones
        /// </summary>
        /// <param name="c">el caracter(Char)</param>
        /// <param name="espacios">Bool que si es True permite espacios, si es False los deneiga</param>
        /// <param name="excepciones">El listado de caracteres que no se tome como Letras pero
        /// que sean validos para el ingreso </param>
        /// <returns> Retorna si el Caracter cumple con lo pedido o si no lo cumple</returns>
        public bool validarSiCaracterEsLetra(Char c, bool espacios, String excepciones)
        {
            //Si excepcion esta vacio, no hay que tenerlas encuenta
            //Sino, no las tiene en cuenta
            if (String.IsNullOrWhiteSpace(excepciones))//Letras
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
                //Para el Backspace(borrar)
                else if (char.IsControl(c))
                {
                    return true;
                }
                //Si los espacios estan activados
                //Comprueba que sea un espacio
                //Sino ni lo toma en cuenta(va al else)
                else if (espacios && (c == ' '))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else//Letras y personalizado
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
                else if (char.IsControl(c))
                {
                    return true;
                }
                else if (espacios && (c == ' '))
                {
                    return true;
                }
                //Si esta dentro de las expeciones
                else if (validarExcepciones(c, excepciones))
                {
                    return true;
                }
                else//Si no es ni una letra o un espacio ni es valido
                {
                    return false;
                }
            }

        }

        /// <summary>
        /// Valida el caracter permitiendo solo Digitos, permite/deniega el uso
        /// de espacios y permite un listado de excepciones
        /// </summary>
        /// <param name="c">el caracte(Char)</param>
        /// <param name="espacios">Bool que si es True permite espacios, si es False los deneiga</param>
        /// <param name="excepciones">El listado de caracteres que no se tome como Digito pero
        /// que sean validos para el ingreso </param>
        /// <returns> Retorna si el Caracter cumple con lo pedido o si no lo cumple</returns>
        public bool validarSiCaracterEsDigito(Char c, bool espacios, String excepciones)
        {
            //Si excepcion esta vacio, no hay que tenerlas encuenta
            //Sino, no las tiene en cuenta
            if (String.IsNullOrWhiteSpace(excepciones))//Digitos
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
                //Para el Backspace(borrar)
                else if (char.IsControl(c))
                {
                    return true;
                }
                //Si excepcion esta vacio, no hay que tenerlas encuenta
                //Sino, no las tiene en cuenta //Si los espacios estan activados
                //Comprueba que sea un espacio
                //Sino ni lo toma en cuenta(va al else)
                else if (espacios && (c == ' '))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else//Digitos y personalizado
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
                else if (char.IsControl(c))
                {
                    return true;
                }
                else if (espacios && (c == ' '))
                {
                    return true;
                }
                //Si esta dentro de las expeciones
                else if (validarExcepciones(c, excepciones))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        #endregion

        #region Metodos de validacion de Strings
        /// <summary>
        /// Valida que el Texto no este vacio y su largo maximo(-1 para que no valide esto)
        /// </summary>
        /// <param name="texto"> El texto cuestion</param>
        /// <param name="largoMax"> El largo maximo</param>
        /// <returns> Retorna si el Texto es valido o no</returns>
        public bool validarVacio(String texto, int largoMax)
        {
            if (!String.IsNullOrWhiteSpace(texto))
            {
                if (largoMax == -1)//Que directamente no valide el largo
                {
                    return true;
                }
                else if (texto.Length <= largoMax)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
      
        /// <summary>
        /// Valida un texto no este vacio, su largo maximo(-1 para que no lo valide), valida si puedo contener 
        /// espacios o no y que todos los caracteres sean letras, acepta excepciones ademas de las letras
        /// </summary>
        /// <param name="texto"> el texto a validar</param>
        /// <param name="largoMax"> el largo maximo del texto</param>
        /// <param name="espacios">true si se permiten espacios y false si no</param>
        /// <param name="excepciones">Lista de expceciones(separadas por espacios)</param>
        /// <returns>
        /// Retorna:
        /// 0 Si es valida
        /// -1 si esta vacio
        /// -2 si supera su rango maxima
        /// -3 si alguno de sus caracteres no son letras o no pertenesn a las excepciones
        /// </returns>
        public int validarLetras(String texto, int largoMax, bool espacios, String excepciones)
        {
            //Si no esta vacio
            if(!String.IsNullOrWhiteSpace(texto))
            {
                //Si tiene cumple esta dentro del rango o si no lo considera
                if(texto.Length <= largoMax || largoMax == -1)
                {
                    bool valido = true;
                    foreach (Char c in texto)
                    {
                        //Valida caracter por caracter con los parametros indicados
                        if (!validarSiCaracterEsLetra(c, espacios, excepciones))
                        {
                            valido = false;
                            break;
                        }
                    }

                    //Si todos los caracteres validos
                    if (valido)
                    {
                        //Retorna 0 si la cadena es valida
                        return 0;
                    }
                    else
                    {
                        //Retorna -3 si todos sus caracteres no son letras o no estan en la excepciones
                        return -3;
                    }
                }
                else
                {
                    //Retorna -2 si no cumple con su rango maximo
                    return -2;
                }
            }
            else
            {
                //Retorna -1 si esta vacio
                return -1;
            }
        }

        /// <summary>
        /// Valida un texto no este vacio, su largo maximo(-1 para que no lo valide), valida si puedo contener 
        /// espacios o no y que todos los caracteres sean letras, acepta excepciones ademas de las digitos
        /// </summary>
        /// <param name="texto"> el texto a validar</param>
        /// <param name="largoMax"> el largo maximo del texto</param>
        /// <param name="espacios">true si se permiten espacios y false si no</param>
        /// <param name="excepciones">Lista de expceciones(separadas por espacios)</param>
        /// <returns>
        /// Retorna:
        /// 0 Si es valida
        /// -1 si esta vacio
        /// -2 si supera su rango maxima
        /// -3 si alguno de sus caracteres no son digitos o no pertenesn a las excepciones
        /// </returns>
        public int validarDigitos(String texto, int largoMax, bool espacios, String excepciones)
        {
            //Si no esta vacio
            if (!String.IsNullOrWhiteSpace(texto))
            {
                //Si tiene cumple esta dentro del rango o si no lo considera
                if (texto.Length <= largoMax || largoMax == -1)
                {
                    bool valido = true;
                    foreach (Char c in texto)
                    {
                        //Valida caracter por caracter con los parametros indicados
                        if (!validarSiCaracterEsDigito(c, espacios, excepciones))
                        {
                            valido = false;
                            break;
                        }
                    }

                    //Si todos los caracteres validos
                    if (valido)
                    {
                        //Retorna 0 si la cadena es valida
                        return 0;
                    }
                    else
                    {
                        //Retorna -3 si todos sus caracteres no son letras o no estan en la excepciones
                        return -3;
                    }
                }
                else
                {
                    //Retorna -2 si no cumple con su rango maximo
                    return -2;
                }
            }
            else
            {
                //Retorna -1 si esta vacio
                return -1;
            }
        }

        /// <summary>
        /// Valida un texto no este vacio, su largo maximo(-1 para que no lo valide), valida si puedo contener 
        /// espacios o no y que todos los caracteres sean letras, acepta excepciones ademas de las letras o digitos
        /// </summary>
        /// <param name="texto"> el texto a validar</param>
        /// <param name="largoMax"> el largo maximo del texto</param>
        /// <param name="espacios">true si se permiten espacios y false si no</param>
        /// <param name="excepciones">Lista de expceciones(separadas por espacios)</param>
        /// <returns>
        /// Retorna:
        /// 0 Si es valida
        /// -1 si esta vacio
        /// -2 si supera su rango maxima
        /// -3 si alguno de sus caracteres no son letras, digitos o no pertenesn a las excepciones
        /// </returns>
        public int validarLetrasDigitos(String texto, int largoMax, bool espacios, String excepciones)
        {
            //Si no esta vacio
            if (!String.IsNullOrWhiteSpace(texto))
            {
                //Si tiene cumple esta dentro del rango o si no lo considera
                if (texto.Length <= largoMax || largoMax == -1)
                {
                    bool valido = true;
                    foreach (Char c in texto)
                    {
                        //Valida caracter por caracter con los parametros indicados
                        if (!validarSiCaracterEsDigitoLetra(c, espacios, excepciones))
                        {
                            valido = false;
                            break;
                        }
                    }

                    //Si todos los caracteres validos
                    if (valido)
                    {
                        //Retorna 0 si la cadena es valida
                        return 0;
                    }
                    else
                    {
                        //Retorna -3 si todos sus caracteres no son letras, digitos  o no estan en la excepciones
                        return -3;
                    }
                }
                else
                {
                    //Retorna -2 si no cumple con su rango maximo
                    return -2;
                }
            }
            else
            {
                //Retorna -1 si esta vacio
                return -1;
            }
        }
        #endregion

        #region Metodos de validacion de Fechas y Horas
        /// <summary>
        /// Valida si la Fecha de Inicio es anterior o igual a la Fecha de Fin
        /// </summary>
        /// <param name="dtpHoraInicio">Fecha de Inicio</param>
        /// <param name="dtpHoraFin">Fecha de Fin</param>
        /// <returns> Si la fecha de Inicio es anterior a la de Fin </returns>
        public bool validarFechaPrimeraEsMenor(DateTime fechaInicio, DateTime fechaFin)
        {
            //Convierto las fechas a short(dia,mes,año)
            fechaInicio = DateTime.Parse(fechaInicio.ToShortDateString());
            fechaFin = DateTime.Parse(fechaFin.ToShortDateString());

            //Si la fecha de inicio es <= a la de fin retorna true
            if (DateTime.Compare(fechaInicio, fechaFin) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determina si la fecha(en el formato ShortDate) intermedia esta entre la fecha de inicio y la fecha de fin
        /// </summary>
        /// <param name="fechaIntermedia">La Fecha intermedia</param>
        /// <param name="fechaInicio">La Fecha de Inicio</param>
        /// <param name="fechaFin">La Fecha de Fin</param>
        /// <returns>Retronar True si al fecha intermedia se encuentra entre Inicio y Fin, y False sino </returns>
        public bool validarFechaIntermedia(DateTime fechaIntermedia, DateTime fechaInicio, DateTime fechaFin)
        {
            //Convierto las fechas a short(dia,mes,año)
            fechaInicio = DateTime.Parse(fechaInicio.ToShortDateString());
            fechaFin = DateTime.Parse(fechaFin.ToShortDateString());
            fechaIntermedia = DateTime.Parse(fechaIntermedia.ToShortDateString());

            //Si la fecha de inicio es <= a la de fin y >= a la de inicio retorna true
            if ((fechaIntermedia >= fechaInicio) && (fechaIntermedia <= fechaFin))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Valida si la Hora de Inicio es anterior a la Hora de Fin
        /// </summary>
        /// <param name="dtpHoraInicio">Hora de Inicio</param>
        /// <param name="dtpHoraFin">Hora de Fin</param>
        /// <returns> Si la hora de Inicio es anterior a la de Fin </returns>
        public bool validarHoraPrimeraEsMayor(DateTime horaInicio, DateTime horaFin)
        {
            //Convierto las horas a short(hora,minutos)
            horaInicio = DateTime.Parse(horaInicio.ToShortTimeString());
            horaFin = DateTime.Parse(horaFin.ToShortTimeString());

            //Si la hora de inicio es <= a la de fin retorna true
            if (DateTime.Compare(horaInicio, horaFin) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determina si la 'Hora(en el formato ShortTime) intermedia esta entre la Hora de inicio y la Hora de fin
        /// </summary>
        /// <param name="dtpFechaIntermedia">La Hora intermedia</param>
        /// <param name="dtpFechaInico">La Hora de Inicio</param>
        /// <param name="dtpFechaFin">La Hora de Fin</param>
        /// <returns>Retronar True si al Hora intermedia se encuentra entre Inicio y Fin, y False sino </returns>
        public bool validarHoraIntermedia(DateTime horaIntermedia, DateTime horaInicio, DateTime horaFin)
        {
            //Convierto las hora a short(hora,minutos)
            horaInicio = DateTime.Parse(horaInicio.ToShortTimeString());
            horaFin = DateTime.Parse(horaFin.ToShortTimeString());
            horaIntermedia = DateTime.Parse(horaIntermedia.ToShortTimeString());

            //Si la hora de inicio es <= a la de fin y <= a la de inicio retorna true
            if ((horaIntermedia >= horaInicio) && (horaIntermedia <= horaFin))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion Metodos de validacion de Fechas y Horas

    }
}
