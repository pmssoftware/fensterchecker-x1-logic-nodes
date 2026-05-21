using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;
using LogicModule.Nodes.Helpers;
using LogicModule.ObjectModel;
using LogicModule.ObjectModel.TypeSystem;

namespace pms_software_outlook_com.Logic.Fensterchecker
{
    public class Fensterchecker : LogicNodeBase
    {


        private static new readonly ResourceManager ResourceManager =
            new ResourceManager(
                "pms_software_outlook_com.Logic.Fensterchecker.Resources",
                typeof(Fensterchecker).Assembly);



        private const int FullMaxLength = 255;



        public Fensterchecker(INodeContext context)
            : base(context)
        {
            context.ThrowIfNull("context");

            var typeService =
                context.GetService<ITypeService>();



            this.CompactMaxLengthParameter =
                typeService.CreateDouble(
                    PortTypes.Number,
                    "Zeichen Angepasste Länge");

            this.CompactMaxLengthParameter.Value = 14;

            this.ClosedTextParameter =
                typeService.CreateString(
                    PortTypes.String,
                    "Text wenn geschlossen");

            this.ClosedTextParameter.Value =
                "Alle Fenster zu";

            this.PushPrefixParameter =
                typeService.CreateString(
                    PortTypes.String,
                    "Push Präfix");

            this.PushPrefixParameter.Value =
                "Fenster offen: ";

            this.PushSuffixParameter =
                typeService.CreateString(
                    PortTypes.String,
                    "Push Suffix");

            this.PushSuffixParameter.Value =
                "";


            CreateWindow(typeService, 1);
            CreateWindow(typeService, 2);
            CreateWindow(typeService, 3);
            CreateWindow(typeService, 4);
            CreateWindow(typeService, 5);
            CreateWindow(typeService, 6);
            CreateWindow(typeService, 7);
            CreateWindow(typeService, 8);
            CreateWindow(typeService, 9);
            CreateWindow(typeService, 10);
            CreateWindow(typeService, 11);
            CreateWindow(typeService, 12);
            CreateWindow(typeService, 13);
            CreateWindow(typeService, 14);
            CreateWindow(typeService, 15);
            CreateWindow(typeService, 16);
            CreateWindow(typeService, 17);
            CreateWindow(typeService, 18);
            CreateWindow(typeService, 19);
            CreateWindow(typeService, 20);
            CreateWindow(typeService, 21);
            CreateWindow(typeService, 22);
            CreateWindow(typeService, 23);
            CreateWindow(typeService, 24);



            this.AllClosed =
                typeService.CreateBool(
                    PortTypes.Binary,
                    "Alle Fenster zu");

            this.OpenWindowCount =
                typeService.CreateDouble(
                    PortTypes.Number,
                    "Offene Fenster");

            this.CompactText =
                typeService.CreateString(
                    PortTypes.String,
                    "Angepasste Länge");

            this.FullText =
                typeService.CreateString(
                    PortTypes.String,
                    "Volle Länge");

            this.PushNotificationText =
                typeService.CreateString(
                    PortTypes.String,
                    "Push mit Präfix/Suffix");
        }



        [Parameter]
        public DoubleValueObject CompactMaxLengthParameter
        {
            get;
            private set;
        }

        [Parameter]
        public StringValueObject ClosedTextParameter
        {
            get;
            private set;
        }

        [Parameter]
        public StringValueObject PushPrefixParameter
        {
            get;
            private set;
        }

        [Parameter]
        public StringValueObject PushSuffixParameter
        {
            get;
            private set;
        }



        private readonly List<BoolValueObject> windowStates =
            new List<BoolValueObject>();

        private readonly List<StringValueObject> windowNames =
            new List<StringValueObject>();


        [Output]
        public BoolValueObject AllClosed
        {
            get;
            private set;
        }

        [Output]
        public DoubleValueObject OpenWindowCount
        {
            get;
            private set;
        }

        [Output]
        public StringValueObject CompactText
        {
            get;
            private set;
        }

        [Output]
        public StringValueObject FullText
        {
            get;
            private set;
        }

        [Output]
        public StringValueObject PushNotificationText
        {
            get;
            private set;
        }



        [Input] public BoolValueObject WindowState01 { get; private set; }
        [Input] public BoolValueObject WindowState02 { get; private set; }
        [Input] public BoolValueObject WindowState03 { get; private set; }
        [Input] public BoolValueObject WindowState04 { get; private set; }
        [Input] public BoolValueObject WindowState05 { get; private set; }
        [Input] public BoolValueObject WindowState06 { get; private set; }
        [Input] public BoolValueObject WindowState07 { get; private set; }
        [Input] public BoolValueObject WindowState08 { get; private set; }
        [Input] public BoolValueObject WindowState09 { get; private set; }
        [Input] public BoolValueObject WindowState10 { get; private set; }
        [Input] public BoolValueObject WindowState11 { get; private set; }
        [Input] public BoolValueObject WindowState12 { get; private set; }
        [Input] public BoolValueObject WindowState13 { get; private set; }
        [Input] public BoolValueObject WindowState14 { get; private set; }
        [Input] public BoolValueObject WindowState15 { get; private set; }
        [Input] public BoolValueObject WindowState16 { get; private set; }
        [Input] public BoolValueObject WindowState17 { get; private set; }
        [Input] public BoolValueObject WindowState18 { get; private set; }
        [Input] public BoolValueObject WindowState19 { get; private set; }
        [Input] public BoolValueObject WindowState20 { get; private set; }
        [Input] public BoolValueObject WindowState21 { get; private set; }
        [Input] public BoolValueObject WindowState22 { get; private set; }
        [Input] public BoolValueObject WindowState23 { get; private set; }
        [Input] public BoolValueObject WindowState24 { get; private set; }

        [Parameter] public StringValueObject WindowName01 { get; private set; }
        [Parameter] public StringValueObject WindowName02 { get; private set; }
        [Parameter] public StringValueObject WindowName03 { get; private set; }
        [Parameter] public StringValueObject WindowName04 { get; private set; }
        [Parameter] public StringValueObject WindowName05 { get; private set; }
        [Parameter] public StringValueObject WindowName06 { get; private set; }
        [Parameter] public StringValueObject WindowName07 { get; private set; }
        [Parameter] public StringValueObject WindowName08 { get; private set; }
        [Parameter] public StringValueObject WindowName09 { get; private set; }
        [Parameter] public StringValueObject WindowName10 { get; private set; }
        [Parameter] public StringValueObject WindowName11 { get; private set; }
        [Parameter] public StringValueObject WindowName12 { get; private set; }
        [Parameter] public StringValueObject WindowName13 { get; private set; }
        [Parameter] public StringValueObject WindowName14 { get; private set; }
        [Parameter] public StringValueObject WindowName15 { get; private set; }
        [Parameter] public StringValueObject WindowName16 { get; private set; }
        [Parameter] public StringValueObject WindowName17 { get; private set; }
        [Parameter] public StringValueObject WindowName18 { get; private set; }
        [Parameter] public StringValueObject WindowName19 { get; private set; }
        [Parameter] public StringValueObject WindowName20 { get; private set; }
        [Parameter] public StringValueObject WindowName21 { get; private set; }
        [Parameter] public StringValueObject WindowName22 { get; private set; }
        [Parameter] public StringValueObject WindowName23 { get; private set; }
        [Parameter] public StringValueObject WindowName24 { get; private set; }



        private void CreateWindow(
            ITypeService typeService,
            int number)
        {
            string num =
                number.ToString("00");

            var state =
                typeService.CreateBool(
                    PortTypes.Binary,
                    "Fenster " + num + " Status");

            var name =
                typeService.CreateString(
                    PortTypes.String,
                    "Fenster " + num + " Name");

            name.Value =
                "Fenster " + num;

            windowStates.Add(state);
            windowNames.Add(name);

            switch (number)
            {
                case 1:
                    WindowState01 = state;
                    WindowName01 = name;
                    break;
                case 2:
                    WindowState02 = state;
                    WindowName02 = name;
                    break;
                case 3:
                    WindowState03 = state;
                    WindowName03 = name;
                    break;
                case 4:
                    WindowState04 = state;
                    WindowName04 = name;
                    break;
                case 5:
                    WindowState05 = state;
                    WindowName05 = name;
                    break;
                case 6:
                    WindowState06 = state;
                    WindowName06 = name;
                    break;
                case 7:
                    WindowState07 = state;
                    WindowName07 = name;
                    break;
                case 8:
                    WindowState08 = state;
                    WindowName08 = name;
                    break;
                case 9:
                    WindowState09 = state;
                    WindowName09 = name;
                    break;
                case 10:
                    WindowState10 = state;
                    WindowName10 = name;
                    break;
                case 11:
                    WindowState11 = state;
                    WindowName11 = name;
                    break;
                case 12:
                    WindowState12 = state;
                    WindowName12 = name;
                    break;
                case 13:
                    WindowState13 = state;
                    WindowName13 = name;
                    break;
                case 14:
                    WindowState14 = state;
                    WindowName14 = name;
                    break;
                case 15:
                    WindowState15 = state;
                    WindowName15 = name;
                    break;
                case 16:
                    WindowState16 = state;
                    WindowName16 = name;
                    break;
                case 17:
                    WindowState17 = state;
                    WindowName17 = name;
                    break;
                case 18:
                    WindowState18 = state;
                    WindowName18 = name;
                    break;
                case 19:
                    WindowState19 = state;
                    WindowName19 = name;
                    break;
                case 20:
                    WindowState20 = state;
                    WindowName20 = name;
                    break;
                case 21:
                    WindowState21 = state;
                    WindowName21 = name;
                    break;
                case 22:
                    WindowState22 = state;
                    WindowName22 = name;
                    break;
                case 23:
                    WindowState23 = state;
                    WindowName23 = name;
                    break;
                case 24:
                    WindowState24 = state;
                    WindowName24 = name;
                    break;
            }
        }



        public override void Execute()
        {
            var openWindows =
                new List<string>();

            for (int i = 0;
                 i < windowStates.Count;
                 i++)
            {
                CheckWindow(
                    windowStates[i],
                    windowNames[i],
                    "Fenster " + (i + 1).ToString("00"),
                    openWindows);
            }

            int openCount =
                openWindows.Count;

            bool allClosed =
                openCount == 0;

            this.AllClosed.Value =
                allClosed;

            this.OpenWindowCount.Value =
                openCount;

            string closedText =
                this.ClosedTextParameter.Value;

            string fullText;

            if (allClosed)
            {
                fullText =
                    closedText;
            }
            else
            {
                fullText =
                    string.Join(", ", openWindows);
            }

            if (fullText.Length > FullMaxLength)
            {
                fullText =
                    fullText.Substring(0, FullMaxLength);
            }

            this.FullText.Value =
                fullText;

            string compactText;

            if (allClosed)
            {
                compactText =
                    closedText;
            }
            else
            {
                compactText =
                    GenerateCompactText(
                        openWindows,
                        (int)this.CompactMaxLengthParameter.Value);
            }

            this.CompactText.Value =
                compactText;

            string pushText;

            if (allClosed)
            {
                pushText =
                    closedText;
            }
            else
            {
                pushText =
                    this.PushPrefixParameter.Value +
                    fullText +
                    this.PushSuffixParameter.Value;
            }

            this.PushNotificationText.Value =
                pushText;
        }


        private void CheckWindow(
            BoolValueObject stateInput,
            StringValueObject nameInput,
            string fallbackName,
            List<string> openWindows)
        {
            if (!stateInput.HasValue)
            {
                return;
            }

            bool isOpen =
                !stateInput.Value;

            if (!isOpen)
            {
                return;
            }

            string windowName =
                fallbackName;

            if (nameInput != null &&
                nameInput.HasValue &&
                !string.IsNullOrWhiteSpace(
                    nameInput.Value))
            {
                windowName =
                    nameInput.Value;
            }

            openWindows.Add(windowName);
        }



        private string GenerateCompactText(
            List<string> openWindows,
            int maxLength)
        {
            if (openWindows.Count == 0)
            {
                return this.ClosedTextParameter.Value;
            }

            string full =
                string.Join(", ", openWindows);

            if (full.Length <= maxLength)
            {
                return full;
            }

            var builder =
                new StringBuilder();

            for (int i = 0;
                 i < openWindows.Count;
                 i++)
            {
                string currentName =
                    openWindows[i];

                int remaining =
                    openWindows.Count - (i + 1);

                string suffix =
                    remaining > 0
                        ? " +" + remaining
                        : "";

                string test;

                if (builder.Length == 0)
                {
                    test =
                        currentName +
                        suffix;
                }
                else
                {
                    test =
                        builder.ToString() +
                        ", " +
                        currentName +
                        suffix;
                }

                if (test.Length <= maxLength)
                {
                    if (builder.Length > 0)
                    {
                        builder.Append(", ");
                    }

                    builder.Append(currentName);
                }
                else
                {
                    if (builder.Length == 0)
                    {
                        return "+" +
                               openWindows.Count;
                    }

                    return builder.ToString() +
                           suffix;
                }
            }

            return builder.ToString();
        }



        public override void Startup()
        {
            base.Startup();
        }



        public override string Localize(
            string language,
            string key)
        {
            try
            {
                string localized =
                    ResourceManager.GetString(
                        key,
                        new System.Globalization.CultureInfo(
                            language));

                if (!string.IsNullOrEmpty(localized))
                {
                    return localized;
                }
            }
            catch
            {
            }

            return key;
        }
    }
}