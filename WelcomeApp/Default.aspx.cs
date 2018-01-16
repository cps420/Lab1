using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WelcomeApp
{
    public partial class Default : System.Web.UI.Page
    {
        /// <summary>
        /// The amount of money that the given item costs without a
        /// discount price. This is the base cost. The setter places
        /// the value in the text box.
        /// </summary>
        protected float SalesPrice
        {
            get { return float.Parse(txtSalesPrice.Text); }
            set { txtSalesPrice.Text = value.ToString(); }
        }

        /// <summary>
        /// The percent of money taken off of the original sales price
        /// in <see cref="SalesPrice"/>. The value returned will be the
        /// percent as a decimal (46% --> 0.46). The setter places the value
        /// in the text box.
        /// </summary>
        protected float DiscountPercent
        {
            get { return float.Parse(txtDiscountPercent.Text) / 100; }
            set { txtDiscountPercent.Text = value.ToString(); }
        }

        /// <summary>
        /// The actual amount of money taken out of the original sales price.
        /// This simply multiplies <see cref="SalesPrice"/> by
        /// <see cref="DiscountPercent"/>.
        /// </summary>
        protected float DiscountAmount
        {
            get {
                return this.SalesPrice * this.DiscountPercent;
            }
            set { txtSalesPrice.Text = value.ToString(); }
        }

        /// <summary>
        /// Returns the final total cost of this item after factoring in the
        /// discount amount.
        /// </summary>
        /// <returns></returns>
        protected float GetTotal()
        {
            return this.SalesPrice - this.DiscountAmount;
        }

        /// <summary>
        /// Determines whether or not a valid value has been entered for the sales price.
        /// If not, a warning label is shown and false is returned. Otherwise, the
        /// warning is hidden and true is returned.
        /// 
        /// This field is valid if:
        /// 1. There is a value
        /// 2. The value is a number between 10 and 1000
        /// </summary>
        /// <returns></returns>
        protected bool ValidateSalesPrice()
        {
            try
            {
                if (txtSalesPrice.Text == "" || txtSalesPrice == null)
                {
                    this.Warn(lblWarningSalesPrice, "This field is required.");
                    return false;
                }
                else if (float.Parse(txtSalesPrice.Text) < 10 ||
                          float.Parse(txtSalesPrice.Text) > 1000)
                {
                    this.Warn(lblWarningSalesPrice, "Must be between 10 and 1000 (inclusive).");
                    return false;
                }
                else
                {
                    lblWarningSalesPrice.Visible = false;
                    return true;
                }
            } catch (FormatException e)
            {
                this.Warn(lblWarningSalesPrice, "Must be a number between 10 and 1000 (inclusive).");
                return false;
            }
        }

        /// <summary>
        /// Determines whether or not a valid value has been entered for the discount
        /// percent. If not, a warning label is shown and false is returned.
        /// Otherwise, the warning is hidden and true is returned.
        /// 
        /// This field is valid if:
        /// 1. There is a value
        /// 2. The value is a number between 10 and 50
        /// </summary>
        /// <returns></returns>
        protected bool ValidateDiscountPercent()
        {
            try
            {
                if (txtDiscountPercent.Text == "" || txtDiscountPercent == null)
                {
                    this.Warn(lblWarningDiscountPercent, "This field is required.");
                    return false;
                }
                else if (float.Parse(txtDiscountPercent.Text) < 10 ||
                          float.Parse(txtDiscountPercent.Text) > 50)
                {
                    this.Warn(lblWarningDiscountPercent, "Must be between 10 and 50 (inclusive).");
                    return false;
                }
                else
                {
                    lblWarningDiscountPercent.Visible = false;
                    return true;
                }
            } catch (FormatException e)
            {
                this.Warn(lblWarningDiscountPercent, "Must be a number between 10 and 50 (inclusive).");
                return false;
            }
        }

        /// <summary>
        /// Determines whether or not all fields in the form are valid, showing
        /// any warning labels as necessary.
        /// </summary>
        /// <returns></returns>
        protected bool ValidateForm()
        {
            bool isValid = true;

            if (!this.ValidateSalesPrice()) isValid = false;
            if (!this.ValidateDiscountPercent()) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Sets the warning message for a warning label and shows the label on the page.
        /// </summary>
        /// <param name="warningLabel"></param>
        /// <param name="message"></param>
        protected void Warn(Label warningLabel, String message)
        {
            warningLabel.Text = message;
            warningLabel.Visible = true;
        }

        /// <summary>
        /// Calulates the final total cost with the discount factored in and
        /// displays the result on the total label on the page. The amount
        /// discounted is also displayed on it's own label.
        /// </summary>
        protected void EvaluateForm()
        {
            if (this.ValidateForm())
            {
                lblDiscountAmount.Text = this.DiscountAmount.ToString();
                lblTotal.Text = this.GetTotal().ToString();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lblWarningSalesPrice.Visible = false;
            lblWarningDiscountPercent.Visible = false;
        }

        /// <summary>
        /// Action for Calculate button. When this is clicked, the Total cost
        /// with the discount is caclulated and displayed on the total label.
        /// The amount discounted is also displayed on it's own label.
        /// 
        /// This is done by calling <see cref="EvaluateForm"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            this.EvaluateForm();
        }
    }
}