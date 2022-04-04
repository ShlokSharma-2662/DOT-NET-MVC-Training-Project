using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class InsertRecord
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string CreatedAt { get; set; }

        public string EditedAt { get; set; }

        public string DeletedAt { get; set; }


        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string ContactNo { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public char Gender { get; set; }
        [Required]
        public char Status { get; set; }

        public void setId(int Id)
        {
            this.Id = Id;
        }

        public int getId()
        {
            return this.Id;
        }

        public void setCreatedAt(string CreatedAt)
        {
            this.CreatedAt = CreatedAt;
        }
        public string getCreatedAt()
        {
            return this.CreatedAt;
        }

        public void setEditedAt(string EditedAt)
        {
            this.EditedAt = EditedAt;
        }
        public string getEditedAt()
        {
            return this.DeletedAt;
        }

        public void setDeletedAt(string DeletedAt)
        {
            this.DeletedAt = DeletedAt;
        }
        public string getDeletedAt()
        {
            return this.DeletedAt;
        }

        public void setFirstName(string FirstName)
        {
            this.FirstName = FirstName;
        }
        public string getFirstName()
        {
            return this.FirstName;
        }
        public void setLastName(string LastName)
        {
            this.LastName = LastName;
        }
        public string getLastName()
        {
            return this.LastName;
        }
        public void setContactNo(string ContactNo)
        {
            this.ContactNo = ContactNo;
        }
        public string getContactNo()
        {
            return this.ContactNo;
        }
        public string getEmail()
        {
            return this.Email;
        }
        public void setEmail(string Email)
        {
            this.Email = Email;
        }

        public void setGender(char Gender)
        {
            this.Gender = Gender;
        }
        public char getGender()
        {
            return this.Gender;
        }
        public void setStatus(char Status)
        {
            this.Status = Status;
        }
        public char getStatus()
        {
            return this.Status;
        }

    }
}

