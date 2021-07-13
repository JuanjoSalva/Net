#Validating MVC Applications Custom Validations</br></br>
###Para validación con validaciones personalizadas</br>
**Se crea, a nivel de proyecto, una carpeta llamada Validators y dentro una o varias clases para las validaciones. En nuestro caso una.**</br>
<pre><code>
public class InUniversityValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Student student = (Student)validationContext.ObjectInstance;
            if (!student.UniversityStudent)
            {
                return new ValidationResult("Sorry you must be a student of the university in order to submit");
            }
            return ValidationResult.Success;
        }
    }
</code></pre>    
</br></br>
Esta clase valida que el campo UniversityStudent haya sido marcado. Si no es valido retorna ValidationResult = "Sorry you must be a student of the university in order to submit"</br>
Si es valida retorna Success

</br></br>
Para que funcione esta validación, en la propia calse se adorna el campo que se quiera validar con esta clase [InUniversityValidation] que es el nombre de la clase:</br>
<pre><code>
 [Display(Name = "Are you a university student?")]
 [InUniversityValidation]
 public bool UniversityStudent { get; set; }
 </code></pre> </br></br>
 
