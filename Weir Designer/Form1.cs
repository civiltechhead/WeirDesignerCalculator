using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weir_Designer
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        // Local values
        public string flow_local, inflow_local, froude_local, area_local, perimeter_local, curvature_local, freeboard_local, water_rise_local, fvelocity_local;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        public void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void surpressed_CheckedChanged(object sender, EventArgs e)
        {
            weir_picture.Image = Properties.Resources.surpressed_rectangle_weir;

            parameter_1_tb.Enabled = true;
            parameter_2_tb.Enabled = true;
            parameter_3_tb.Enabled = true;
            parameter_4_tb.Enabled = true;
        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            weir_picture.Image = Properties.Resources.singly_contracted_rect_weir;

            parameter_1_tb.Enabled = true;
            parameter_2_tb.Enabled = true;
            parameter_3_tb.Enabled = true;
            parameter_4_tb.Enabled = true;
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            weir_picture.Image = Properties.Resources.doubly_contracted_rect_weir;

            parameter_1_tb.Enabled = true;
            parameter_2_tb.Enabled = true;
            parameter_3_tb.Enabled = true;
            parameter_4_tb.Enabled = true;
        }

        public void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        public void clear_data_Click(object sender, EventArgs e)
        {
            angle.Clear();
            parameter_1_tb.Clear();
            parameter_2_tb.Clear();
            parameter_3_tb.Clear();
            parameter_4_tb.Clear();
            upstream_velocity.Clear();
            downstream_velocity.Clear();
            upstream_depth.Clear();
            downstream_depth.Clear();
            gs_channel.Clear();
            slope.Clear();
            distance.Clear();
            energy_gradient.Clear();
            coefficient_value.Clear();
            uw_water.Clear();
        }

        public void save_data_Click(object sender, EventArgs e)
        {

        }

        public void coefficient_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(coefficient_type.SelectedIndex == 0)
            {
                coefficient_value.Enabled = false;
                coefficient_value.Clear();
            }
            else
            {
                coefficient_value.Enabled = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            weir_type.Items.Add("Rectangular weir");
            weir_type.Items.Add("Triangular weir");
            weir_type.Items.Add("Cipolletti weir");
            weir_type.Items.Add("Broad crested weir (Dam)");

            coefficient_type.Items.Add("Nothing specified");
            coefficient_type.Items.Add("C-coefficient");
            coefficient_type.Items.Add("m-coefficient (Manning)");

            single_contract.Visible = false;
            double_contract.Visible = false;
            surpressed.Visible = false;

            angle.Visible = false;
            label12.Visible = false;

            MaximizeBox = false;

            parameter_1_tb.Enabled = false;
            parameter_2_tb.Enabled = false;
            parameter_3_tb.Enabled = false;
            parameter_4_tb.Enabled = false;

            weir_picture.Image = Properties.Resources.question_mark;
        }

        public void weir_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (weir_type.SelectedIndex == 0)
            {
                weir_picture.Image = Properties.Resources.rectangular_weir;
                single_contract.Visible = true;
                double_contract.Visible = true;
                surpressed.Visible = true;
                
                angle.Visible = false;
                label12.Visible = false;

                parameter_1.Text = "Channel width, W (m)";
                parameter_2.Text = "Weir length, L (m)";
                parameter_3.Text = "Weir height, Z (m)";
                parameter_4.Text = "Weir head, H (m)";

                parameter_1_tb.Clear();
                parameter_2_tb.Clear();
                parameter_3_tb.Clear();
                parameter_4_tb.Clear();

                parameter_1_tb.Enabled = false;
                parameter_2_tb.Enabled = false;
                parameter_3_tb.Enabled = false;
                parameter_4_tb.Enabled = false;

                coefficient_value.Clear();
                coefficient_type.Enabled = true;
                coefficient_value.Enabled = true;

                velocity_no.Enabled = true;
                velocity_yes.Enabled = true;
            }
            else if(weir_type.SelectedIndex == 1)
            {
                single_contract.Checked = false;
                double_contract.Checked = false;
                surpressed.Checked = false;

                weir_picture.Image = Properties.Resources.triangular_weir;

                single_contract.Visible = false;
                double_contract.Visible = false;
                surpressed.Visible = false;

                angle.Visible = true;
                label12.Visible = true;

                parameter_1.Text = "Channel width, W (m)";
                parameter_2.Text = "Weir head, H (m)";
                parameter_3.Text = "Parameter 3";
                parameter_4.Text = "Parameter 4";

                parameter_1_tb.Clear();
                parameter_2_tb.Clear();
                parameter_3_tb.Clear();
                parameter_4_tb.Clear();

                parameter_1_tb.Enabled = true;
                parameter_2_tb.Enabled = true;
                parameter_3_tb.Enabled = false;
                parameter_4_tb.Enabled = false;

                coefficient_value.Clear();
                coefficient_type.Enabled = true;
                coefficient_value.Enabled = true;

                velocity_no.Enabled = true;
                velocity_yes.Enabled = true;
            }
            else if(weir_type.SelectedIndex == 2)
            {
                single_contract.Checked = false;
                double_contract.Checked = false;
                surpressed.Checked = false;

                weir_picture.Image = Properties.Resources.cipolleti_weir;

                single_contract.Visible = false;
                double_contract.Visible = false;
                surpressed.Visible = false;

                angle.Visible = false;
                label12.Visible = false;

                parameter_1.Text = "Channel width, W (m)";
                parameter_2.Text = "Weir length, L (m)";
                parameter_3.Text = "Weir head, H (m)";
                parameter_4.Text = "Parameter 4";

                parameter_1_tb.Clear();
                parameter_2_tb.Clear();
                parameter_3_tb.Clear();
                parameter_4_tb.Clear();

                parameter_1_tb.Enabled = true;
                parameter_2_tb.Enabled = true;
                parameter_3_tb.Enabled = true;
                parameter_4_tb.Enabled = false;

                coefficient_type.Enabled = false;
                coefficient_value.Clear();
                coefficient_value.Enabled = false;
                coefficient_type.SelectedIndex = -1;

                velocity_no.Enabled = false;
                velocity_yes.Enabled = false;
            }
            else if(weir_type.SelectedIndex == 3)
            {
                single_contract.Checked = false;
                double_contract.Checked = false;
                surpressed.Checked = false;

                weir_picture.Image = Properties.Resources.broad_crest;

                single_contract.Visible = false;
                double_contract.Visible = false;
                surpressed.Visible = false;

                angle.Visible = false;
                label12.Visible = false;

                parameter_1.Text = "Weir head, H (m) ";
                parameter_2.Text = "Dam length (m)";
                parameter_3.Text = "Parameter 3 ";
                parameter_4.Text = "Parameter 4 ";

                parameter_1_tb.Clear();
                parameter_2_tb.Clear();
                parameter_3_tb.Clear();
                parameter_4_tb.Clear();

                parameter_1_tb.Enabled = true;
                parameter_2_tb.Enabled = true;
                parameter_3_tb.Enabled = false;
                parameter_4_tb.Enabled = false;

                coefficient_type.Enabled = false;
                coefficient_value.Enabled = false;
                coefficient_type.SelectedIndex = -1;

                velocity_no.Enabled = false;
                velocity_yes.Enabled = false;
            }
            else
            {

            }
        }

        public void weir_picture_Click(object sender, EventArgs e)
        {

        }

        public void calculate_Click(object sender, EventArgs e)
        {
            // Menu prompt/s
            int menu_1 = 0;

            // Weir parameters
            double channel_width = 0, weir_length = 0, weir_height = 0, weir_head = 0, dam_length = 0 , s_angle = 0;

            // Flow description parameters
            double us_velocity = 0, ds_velocity = 0, us_depth = 0, ds_depth = 0, gentle_slope = 0, s_slope = 0, s_distance = 0, e_gradient = 0;
            double water_rise = 0, flow_velocity = 0, freeboard = 0, depth_ave = 0, curvature = 0, froude = 0;

            // Coefficient parameters
            double s_coefficient = 0;

            // Values/results
            double flow = 0, perimeter = 0, area = 0, alpha = 0, in_flow = 0, g = 0, l_prime = 0, pi = 22/7, n_value = 0;

            // Variables in formulas
            double v = 0, w = 0, x = 0, y = 0, z = 0;
            double a = 0, b = 0, c = 0, j = 0, k = 0, l = 0, m = 0, n = 0;

            // Menu check

            if (weir_type.SelectedIndex > -1)
            {
                
            }
            else
            {
                MessageBox.Show("ERROR: Weir type was not selected");
                menu_1 = 6;
            }

            if (weir_type.SelectedIndex == 0)
            {
                double tryparse_1;
                if (surpressed.Checked || single_contract.Checked || double_contract.Checked)
                {
                    if (double.TryParse(parameter_1_tb.Text, out tryparse_1))
                    {
                        double tryparse_2;
                        if (double.TryParse(parameter_2_tb.Text, out tryparse_2))
                        {
                            double tryparse_3;
                            if (double.TryParse(parameter_3_tb.Text, out tryparse_3))
                            {
                                double tryparse_4;
                                if (double.TryParse(parameter_4_tb.Text, out tryparse_4))
                                {

                                }
                                else
                                {
                                    MessageBox.Show("ERROR: Weir head has an invalid input");
                                    menu_1 = 6;
                                }
                            }
                            else
                            {
                                MessageBox.Show("ERROR: Weir height has an invalid input");
                                menu_1 = 6;
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERROR: Weir length has an invalid input");
                            menu_1 = 6;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Channel width has an invalid input");
                        menu_1 = 6;
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: Rectangular section type was not selected");
                    menu_1 = 6;
                }
            }
            else if(weir_type.SelectedIndex == 1)
            {
                double tryparse_5;
                if(double.TryParse(angle.Text, out tryparse_5))
                {
                    double tryparse_6;
                    if (double.TryParse(parameter_1_tb.Text, out tryparse_6))
                    {
                        double tryparse_7;
                        if (double.TryParse(parameter_2_tb.Text, out tryparse_7))
                        {

                        }
                        else
                        {
                            MessageBox.Show("ERROR: Weir head has an invalid input");
                            menu_1 = 6;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Channel width has an invalid input");
                        menu_1 = 6;
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: Angle has an invalid input");
                    menu_1 = 6;
                }
            }
            else if (weir_type.SelectedIndex == 2)
            {
                double tryparse_8;
                if(double.TryParse(parameter_1_tb.Text, out tryparse_8))
                {
                    double tryparse_9;
                    if (double.TryParse(parameter_2_tb.Text, out tryparse_9))
                    {
                        double tryparse_10;
                        if (double.TryParse(parameter_3_tb.Text, out tryparse_10))
                        {

                        }
                        else
                        {
                            MessageBox.Show("ERROR: Weir head has an invalid input");
                            menu_1 = 6;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Weir length has an invalid input");
                        menu_1 = 6;
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: Channel width has an invalid input");
                    menu_1 = 6;
                }
            }
            else if (weir_type.SelectedIndex == 3)
            {
                double tryparse_11;
                if (double.TryParse(parameter_1_tb.Text, out tryparse_11))
                {
                    double tryparse_12;
                    if (double.TryParse(parameter_2_tb.Text, out tryparse_12))
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Dam length has an invalid input");
                        menu_1 = 6;
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: Weir head has an invalid input");
                    menu_1 = 6;
                }
            }

            if(coefficient_type.SelectedIndex > -1)
            {

            }
            else
            {
                MessageBox.Show("ERROR: Coefficient type was not selected");
                menu_1 = 6;
            }
            if (coefficient_type.SelectedIndex == 1 || coefficient_type.SelectedIndex == 2)
            {
                double tryparse_51;
                if (double.TryParse(coefficient_value.Text, out tryparse_51))
                {
                    
                }
                else
                {
                    MessageBox.Show("ERROR: Coefficient value has an invalid input");
                    menu_1 = 6;
                }
            }
            else
            {
                double tryparse_52;
                if (double.TryParse(uw_water.Text, out tryparse_52))
                {
                    double tryparse_53;
                    if (double.TryParse(n_value_tb.Text, out tryparse_53))
                    {
                        if (velocity_yes.Checked || velocity_no.Checked)
                        {

                        }
                        else
                        {
                            MessageBox.Show("ERROR: Neglecting of velocity is not specified");
                            menu_1 = 6;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Specified n-value has an invalid input");
                        menu_1 = 6;
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: Unit weight of water has an invalid input");
                    menu_1 = 6;
                }
            }

            double tryparse_01, tryparse_02, tryparse_03, tryparse_04, tryparse_05, tryparse_06, tryparse_07, tryparse_08;
            
            if (double.TryParse(upstream_velocity.Text, out tryparse_01))
            {
                
            }
            else
            {
                MessageBox.Show("ERROR: Upstream velocity has an invalid input");
                menu_1 = 6;
            }

            if (double.TryParse(downstream_velocity.Text, out tryparse_02))
            {

            }
            else
            {
                MessageBox.Show("ERROR: Downstream velocity has an invalid input");
                menu_1 = 6;
            }

            if (double.TryParse(upstream_depth.Text, out tryparse_03))
            {

            }
            else
            {
                MessageBox.Show("ERROR: Upstream depth has an invalid input");
                menu_1 = 6;
            }

            if (double.TryParse(downstream_depth.Text, out tryparse_04))
            {

            }
            else
            {
                MessageBox.Show("ERROR: Downstream depth has an invalid input");
                menu_1 = 6;
            }

            if (double.TryParse(gs_channel.Text, out tryparse_05))
            {

            }
            else
            {
                MessageBox.Show("ERROR: Gentle slope channel has an invalid input");
                menu_1 = 6;
            }

            if (double.TryParse(slope.Text, out tryparse_06))
            {
                
            }
            else
            {
                MessageBox.Show("ERROR: Slope has an invalid input");
                menu_1 = 6;
            }

            if (double.TryParse(distance.Text, out tryparse_07))
            {

            }
            else
            {
                MessageBox.Show("ERROR: Channel distance has an invalid input");
                menu_1 = 6;
            }

            if (double.TryParse(energy_gradient.Text, out tryparse_08))
            {

            }
            else
            {
                MessageBox.Show("ERROR: Energy gradient  has an invalid input");
                menu_1 = 6;
            }

            // Beginning of calculations

            if (menu_1 == 6)
            {
                
            }
            else
            { 
                us_velocity = Double.Parse(upstream_velocity.Text);
                ds_velocity = Double.Parse(downstream_velocity.Text);
                us_depth = Double.Parse(upstream_depth.Text);
                ds_depth = Double.Parse(downstream_depth.Text);
                gentle_slope = Double.Parse(gs_channel.Text);
                s_slope = Double.Parse(slope.Text);
                s_distance = Double.Parse(distance.Text);
                e_gradient = Double.Parse(energy_gradient.Text);
                g = Double.Parse(uw_water.Text);
                n_value = Double.Parse(n_value_tb.Text);

                if (coefficient_type.SelectedIndex != 0)
                {
                    s_coefficient = Double.Parse(coefficient_value.Text);
                }
                else
                {

                }

                // Calculation for flow
                if (weir_type.SelectedIndex == 0)
                {
                    // Equating the doubles for rectangular weir
                    channel_width = Double.Parse(parameter_1_tb.Text);
                    weir_length = Double.Parse(parameter_2_tb.Text);
                    weir_height = Double.Parse(parameter_3_tb.Text);
                    weir_head = Double.Parse(parameter_4_tb.Text);

                    a = Math.Pow(weir_head + (Math.Pow(us_velocity, 2) / (2 * g)), 1.5);
                    b = Math.Pow(Math.Pow(us_velocity, 2) / (2 * g), 1.5);

                    if (coefficient_type.SelectedIndex == 0)
                    {
                        if (surpressed.Checked)
                        {
                            if(velocity_no.Checked)
                            {
                                flow = 1.84 * weir_length * (a - b);
                            }
                            else if(velocity_yes.Checked)
                            {
                                flow = 1.84 * weir_length * Math.Pow(weir_head, 1.5);
                            }
                        }
                        else if (single_contract.Checked)
                        {
                            if(velocity_no.Checked)
                            {
                                l_prime = weir_length - 0.1 * weir_head;
                                flow = 1.84 * l_prime * (a - b);
                            }
                            else if(velocity_yes.Checked)
                            {
                                l_prime = weir_length - 0.1 * weir_head;
                                flow = 1.84 * l_prime * Math.Pow(weir_head, 1.5);
                            }
                        }
                        else if (double_contract.Checked)
                        {
                            if(velocity_no.Checked)
                            {
                                l_prime = weir_length - 0.2 * weir_head;
                                flow = 1.84 * l_prime * (a - b);
                            }
                            else if(velocity_yes.Checked)
                            {
                                l_prime = weir_length - 0.2 * weir_head;
                                flow = 1.84 * l_prime * Math.Pow(weir_head, 1.5);
                            }
                        }
                        else
                        {

                        }
                    }
                    else if (coefficient_type.SelectedIndex == 1)
                    {
                        if (surpressed.Checked)
                        {
                            if(velocity_no.Checked)
                            {
                                flow = (2 / 3) * s_coefficient * weir_length * Math.Sqrt(2 * g) * (a - b);
                            }
                            else if(velocity_yes.Checked)
                            {
                                flow = (2 / 3) * s_coefficient * weir_length * Math.Sqrt(2 * g) * Math.Pow(weir_head,1.5);
                            }
                            else
                            {
                            
                            }
                        }
                        else if (single_contract.Checked)
                        {
                            if(velocity_no.Checked)
                            {
                                l_prime = weir_length - 0.1 * weir_head;
                                flow = (2 / 3) * s_coefficient * l_prime * Math.Sqrt(2 * g) * (a - b);
                            }
                            else if(velocity_yes.Checked)
                            {
                                l_prime = weir_length - 0.1 * weir_head;
                                flow = (2 / 3) * s_coefficient * l_prime * Math.Sqrt(2 * g) * Math.Pow(weir_head, 1.5);
                            }
                            else
                            {
                            
                            }
                        }
                        else if (double_contract.Checked)
                        {
                            if(velocity_no.Checked)
                            {
                                l_prime = weir_length - 0.2 * weir_head;
                                flow = (2 / 3) * s_coefficient * l_prime * Math.Sqrt(2 * g) * (a - b);
                            }
                            else if(velocity_yes.Checked)
                            {
                                l_prime = weir_length - 0.2 * weir_head;
                                flow = (2 / 3) * s_coefficient * l_prime * Math.Sqrt(2 * g) * Math.Pow(weir_head,1.5);
                            }
                            else
                            {
                            
                            }
                        }
                        else
                        {
                        
                        }
                    }
                    else if(coefficient_type.SelectedIndex == 2)
                    {
                        if (surpressed.Checked)
                        {
                            if (velocity_no.Checked)
                            {
                                flow = s_coefficient * weir_length * (a - b);
                            }
                            else if (velocity_yes.Checked)
                            {
                                flow = s_coefficient * weir_length * Math.Pow(weir_head, 1.5);
                            }
                            else
                            {
                           
                            }
                        }
                        else if (single_contract.Checked)
                        {
                            if (velocity_no.Checked)
                            {
                                l_prime = weir_length - 0.1 * weir_head;
                                flow = s_coefficient * l_prime * (a - b);
                            }
                            else if (velocity_yes.Checked)
                            {
                                l_prime = weir_length - 0.1 * weir_head;
                                flow = s_coefficient * l_prime * Math.Pow(weir_head, 1.5);
                            }
                            else
                            {
                            
                            }
                        }
                        else if (double_contract.Checked)
                        {
                            if (velocity_no.Checked)
                            {
                                l_prime = weir_length - 0.2 * weir_head;
                                flow = s_coefficient * l_prime * (a - b);
                            }
                            else if (velocity_yes.Checked)
                            {
                                l_prime = weir_length - 0.2 * weir_head;
                                flow = s_coefficient * l_prime * Math.Pow(weir_head, 1.5);
                            }
                            else
                            {
                           
                            }
                        }
                        else
                        {
                       
                        }
                    }
                    else
                    {
                
                    }
                }
                else if(weir_type.SelectedIndex == 1)
                {
                    channel_width = Double.Parse(parameter_1_tb.Text);
                    weir_head = Double.Parse(parameter_2_tb.Text);

                    if (coefficient_type.SelectedIndex == 0)
                    {
                        if(velocity_yes.Checked || velocity_no.Checked)
                        {
                            flow = (8 / 15) * s_coefficient * Math.Sqrt(2 * g) * Math.Tan(s_angle * pi / 180 / 2) * Math.Pow(weir_head, 5 / 2);
                        }
                        else
                        {
                       
                        }
                    }   
                    else if (coefficient_type.SelectedIndex == 1)
                    {
                        if(velocity_yes.Checked || velocity_no.Checked)
                        {
                            flow = (8 / 15) * s_coefficient * Math.Sqrt(2 * g) * Math.Tan(s_angle * pi / 180 / 2) * Math.Pow(weir_head, 5 / 2);
                        }
                        else
                        {
                       
                        }
                    }
                    else if (coefficient_type.SelectedIndex == 2)
                    {
                        if(velocity_yes.Checked || velocity_no.Checked)
                        {
                            flow = s_coefficient * Math.Pow(weir_head, 5 / 2);
                        }
                        else
                        {
                      
                        }
                    }
                    else
                    {
                   
                    }
                }
                else if(weir_type.SelectedIndex == 2)
                {
                    channel_width = Double.Parse(parameter_1_tb.Text);
                    weir_length = Double.Parse(parameter_2_tb.Text);
                    weir_head = Double.Parse(parameter_3_tb.Text);

                    flow = 1.86*weir_length*Math.Pow(weir_head, 1.5);
                }
                else if(weir_type.SelectedIndex == 3)
                {
                    weir_head = Double.Parse(parameter_1_tb.Text);
                    dam_length = Double.Parse(parameter_2_tb.Text);

                    flow = 1.71 * weir_length * Math.Pow(weir_head, 1.5);
                }
                else
                {
               
                }

                if(menu_1 == 6)
                {

                }
                else
                {
                    perimeter = weir_head*2 + s_distance*2;

                    area = flow / us_velocity;
                    depth_ave = (us_depth+ds_depth)/2;
                    in_flow = area * us_velocity;
                    froude = us_velocity/(Math.Sqrt(g*us_depth));
                    v = flow * (us_velocity + ds_velocity);
                    w = g * (2 * flow);
                    x = in_flow*ds_velocity*s_distance;

                    water_rise = (v / w) * ((ds_velocity - us_velocity) + (x / flow));
                    flow_velocity = (1 / n_value) * Math.Pow(area / perimeter, 2 / 3) * Math.Pow(e_gradient, 0.5);

                    double slope_rads = s_slope*pi/180;
                    m = 4 * (depth_ave + 0.5 * g * Math.Pow(flow_velocity, 2) * Math.Pow(Math.Cos(slope_rads), 2));
                    n = 1.5 * m;

                    freeboard = 0.61 + 0.037*flow_velocity*Math.Pow(depth_ave, 1/3);
                    curvature = s_distance * Math.Tan(s_slope * pi / 180) + Math.Pow(s_distance, 2) / n;

                    // Localize values to form 2

                    flow_local = Convert.ToString(Math.Round(flow,2));
                    froude_local = Convert.ToString(Math.Round(froude,5));
                    area_local = Convert.ToString(Math.Round(area,2));
                    fvelocity_local = Convert.ToString(Math.Round(flow_velocity,2));
                    perimeter_local = Convert.ToString(Math.Round(perimeter,2));
                    freeboard_local = Convert.ToString(Math.Round(freeboard,5));
                    curvature_local = Convert.ToString(Math.Round(curvature,2));
                    water_rise_local = Convert.ToString(Math.Round(water_rise, 5));

                    Form2 f2 = new Form2();
                    f2.Show();
                } 
            }
        }

        private void parameter_1_Click(object sender, EventArgs e)
        {

        }
    }
}
