using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatTime
{
  /*
Here are the rules for renting each type of boat:

A kayak can only be rented by one adult. Children may not rent a kayak.  So exactly 1 adult and 0 children.
A canoe can be rented by two adults, OR one adult and one child.  There must be exactly two people, at least one adult.
A paddleboard can be rented by one adult, OR one adult and one child. Two adults are not permitted. 
*/
  public partial class Form1 : Form
  {
    public string errors;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // setting up the combo-box
      cmbBoatType.Items.Add("Canoe");
      cmbBoatType.Items.Add("Kayak");
      cmbBoatType.Items.Add("Paddle");

      cmbBoatType.SelectedIndex = 0;
    }

    private void btnCheck_Click(object sender, EventArgs e)
    {
      // gets th boat and feeds it to the validation method.
      string boatType = cmbBoatType.SelectedItem.ToString();
      bool isValid = verifyBoat(boatType);

      // Uses the validation data to either enable button or yell at user.
      if (isValid)
      {
        lblStatus.Text = "Valid";
        btnReserve.Enabled = true;
      }
      else
      {
        MessageBox.Show(errors, "Invalid data");
        errors = "";
        lblStatus.Text = "Invalid";
        btnReserve.Enabled = false;
      }
    }

    private bool verifyBoat(string boatType)
    {
      // gets the cold, hard, data and feeds it to the specific methods.
      int adults = Decimal.ToInt32(numAdults.Value);
      int children = Decimal.ToInt32(numChildren.Value);

      if (boatType == "Canoe")
      {
        return verifyCanoe(adults, children);
      }else if (boatType == "Kayak")
      {
        return verifyKayak(adults, children);
      } else if (boatType == "Paddle")
      {
        return verifyPaddle(adults, children);
      }
      errors = "Please select a boat type.";
      return false;
    }

    private bool verifyCanoe(int adults, int children)
    {
      // Uses the data to see if canoe conditions are fufilled.
      if (adults + children == 2 && adults >= 1)
      {
        return true;
      } else if (adults + children > 2)
      {
        errors = "A canoe can must have exactally two people.";
      }else
      {
        errors = "A canoe must have at least one adult.";
      }
      return false;
    }

    private bool verifyKayak(int adults, int children)
    {
      // Uses the data to see if kayak conditions are fufilled.
      if (adults == 1 && children == 0)
      {
        return true;
      }
      else
      {
        errors = "A kayak can only have one adult rider.";
        return false;
      }
    }

    private bool verifyPaddle(int adults, int children)
    {
      // Uses the data to see if paddleboat conditions are fufilled.
      if (adults + children <= 2 && adults == 1)
      {
        return true;
      }
      else if (adults + children > 2)
      {
        errors = "A paddleboat cannot have more then two people.";
      }
      else
      {
        errors = "A paddleboat must have one adult.";
      }
      return false;
    }

    private void btnReserve_Click(object sender, EventArgs e)
    {
      // it felt weird having this button do nothing
      MessageBox.Show("Your boat has been reserved!", "Success!");
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      // resets everything
      lblStatus.Text = "";
      errors = "";
      btnReserve.Enabled = false;
      numAdults.Value = 0;
      numChildren.Value = 0;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }


  }
}
