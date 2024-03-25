﻿using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools.Dialogs
{
    public partial class EmailBodySelection
    {
        private string Subject
        {
            get
            {
                switch (TabControl1.SelectedIndex)
                {
                    case var @case when @case == tp_Templates.TabIndex:
                        {
                            return ts_Templates.TemplateSubject;
                        }
                    case var case1 when case1 == tp_Custom.TabIndex:
                        {
                            return CustomEmail1.Subject;
                        }

                    default:
                        {
                            return null;
                        }
                }
            }
        }

        private string Body
        {
            get
            {
                switch (TabControl1.SelectedIndex)
                {
                    case var @case when @case == tp_Templates.TabIndex:
                        {
                            return ts_Templates.TemplateValue;
                        }
                    case var case1 when case1 == tp_Custom.TabIndex:
                        {
                            return CustomEmail1.Body;
                        }

                    default:
                        {
                            return null;
                        }
                }
            }
        }

        private Types.GTools.EmailType BodyType
        {
            get
            {
                switch (TabControl1.SelectedIndex)
                {
                    case var @case when @case == tp_Templates.TabIndex:
                        {
                            return Types.GTools.EmailType.HTML;
                        }
                    case var case1 when case1 == tp_Custom.TabIndex:
                        {
                            return Types.GTools.EmailType.PLAIN;
                        }

                    default:
                        {
                            return default;
                        }
                }
            }
        }

        public Types.GTools.EmailContent Content
        {
            get
            {
                return new Types.GTools.EmailContent(Subject, Body, BodyType);
            }
        }

        public Types.TemplateList Templates
        {
            set
            {
                ts_Templates.AddRange(value);
            }
        }

        public EmailBodySelection()
        {
            InitializeComponent();
        }


        private void FinishDialog(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelDialog(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Reload()
        {
            ts_Templates.Reload();
        }

        private void Reload(object sender, EventArgs e) => Reload();
    }
}