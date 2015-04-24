using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Clipeity.Properties;
using Timer = System.Timers.Timer;

namespace Clipeity
{
    public struct ButtonEffectStruct
    {
        public int EffectLevel;
        public Button EffectedButton;
        public Color OriginalColor;
    }

    public class FadeOutTimer : Timer
    {
        private readonly List<ButtonEffectStruct> _effectedButtons = new List<ButtonEffectStruct>();
        private readonly object _lockObject = new object();

        public FadeOutTimer()
        {
            Elapsed += OnElapsed;
        }

        public int EffectLevels { get; set; }
        public Color StartColor { get; set; }
        public Color EndColor { get; set; }

        private void OnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            Console.WriteLine(DateTime.Now);
            var effectedButtonsCopy = new List<ButtonEffectStruct>();
            try
            {
                GetEffectedButtonsListCopy(effectedButtonsCopy);
                if (effectedButtonsCopy.Count <= 0)
                {
                    Enabled = false;
                    return;
                }

                foreach (ButtonEffectStruct buttonEffectStruct in effectedButtonsCopy)
                {
                    if (buttonEffectStruct.EffectLevel == EffectLevels)
                    {
                        SetButtonColor(buttonEffectStruct.EffectedButton, buttonEffectStruct.OriginalColor);
                        EnableDisableControl(buttonEffectStruct.EffectedButton, true);
                    }
                    else
                    {
                        Color? c = GetColorForLevel(buttonEffectStruct.EffectLevel);
                        SetButtonColor(buttonEffectStruct.EffectedButton,
                            c.HasValue ? c.Value : buttonEffectStruct.OriginalColor);
                    }
                }
                UpdateEffectedButtonsListCopy(effectedButtonsCopy);
                UpdateEffectedButtonsList(effectedButtonsCopy);
            }
            catch
            {
            }
        }

        private void UpdateEffectedButtonsList(List<ButtonEffectStruct> effectedButtonsCopy)
        {
            lock (_lockObject)
            {
                _effectedButtons.Clear();
                _effectedButtons.AddRange(effectedButtonsCopy.ToArray());
            }
        }

        private void UpdateEffectedButtonsListCopy(List<ButtonEffectStruct> effectedButtonsCopy)
        {
            if (effectedButtonsCopy.Count > 0)
            {
                for (int index = effectedButtonsCopy.Count - 1; index >= 0; index --)
                {
                    if (effectedButtonsCopy[index].EffectLevel == EffectLevels)
                    {
                        effectedButtonsCopy.RemoveAt(index);
                    }
                    else
                    {
                        ButtonEffectStruct effectButton = effectedButtonsCopy[index];
                        effectButton.EffectLevel = effectedButtonsCopy[index].EffectLevel + 1;
                        effectedButtonsCopy[index] = effectButton;
                    }
                }
            }
        }

        private void GetEffectedButtonsListCopy(List<ButtonEffectStruct> effectedButtonsCopy)
        {
            lock (_lockObject)
            {
                if (_effectedButtons.Count > 0)
                {
                    effectedButtonsCopy.AddRange(_effectedButtons.ToArray());
                }
            }
        }

        private Color? GetColorForLevel(int effectLevel)
        {
            if (EffectLevels == 0)
                return null;
            int dr = EndColor.R - StartColor.R;
            int dg = EndColor.G - StartColor.G;
            int db = EndColor.B - StartColor.B;
            int rdr = dr/EffectLevels;
            int rdg = dg/EffectLevels;
            int rdb = db/EffectLevels;
            int r = StartColor.R + rdr*effectLevel;
            int g = StartColor.G + rdg*effectLevel;
            int b = StartColor.B + rdb*effectLevel;
            Color c = Color.FromArgb(r, g, b);
            Console.WriteLine(Resources.FadeOutTimer_GetColorForLevel_FormatString,
                                StartColor,
                                EndColor,
                                c,
                                dr,dg,db,
                                rdr,rdg,rdb,
                                r,g,b);
            return c;
        }

        private void SetButtonColor(Button btn, Color color)
        {
            if (btn.InvokeRequired)
            {
                btn.Invoke((MethodInvoker) delegate { btn.BackColor = color; });
            }
            else
            {
                btn.BackColor = color;
            }
        }

        public void EnqueueEffectedButton(Button btn)
        {
            try
            {
                lock (_lockObject)
                {
                    _effectedButtons.Add(new ButtonEffectStruct
                    {
                        EffectLevel = 0,
                        EffectedButton = btn,
                        OriginalColor = btn.BackColor
                    });
                }
                if (!Enabled)
                    Enabled = true;
                EnableDisableControl(btn, false);
            }
            catch
            {
            }
        }

        private void EnableDisableControl(Control ctrl, bool enabled)
        {
            var m = (MethodInvoker) delegate { ctrl.Enabled = enabled; };
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(m);
            }
            else
            {
                m();
            }
        }
    }
}