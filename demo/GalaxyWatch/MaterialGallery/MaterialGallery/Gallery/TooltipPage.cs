using ElmSharp;
using Tizen.NET.MaterialComponents;

namespace MaterialGallery
{
    class TooltipPage : BaseGalleryPage
    {
        public override string Name => "Tooltip";

        public override EvasObject CreateContent(EvasObject parent)
        {
            Box box = new ColoredBox(parent);
            box.Show();
            box.PackEnd(GetTitleLabel(parent));

            var button = new MButton(parent)
            {
                Text = "Button",
                WeightX = 1,
                WeightY = 1,
                AlignmentX = 0.5,
                AlignmentY = 0.5,
            };
            button.Show();

            var button2 = new MButton(parent)
            {
                Text = "Click",
                WeightX = 1,
                WeightY = 1,
                AlignmentX = -1,
                AlignmentY = 0.5
            };
            button2.Show();

            var button3 = new MButton(parent)
            {
                IsEnabled = true,
                Text = "Chage Tooltip Button2",
                WeightX = 1,
                WeightY = 1,
                AlignmentX = -1,
                AlignmentY = 0.5,
                BackgroundColor = Color.FromHex("#03A9F4"),
            };
            button3.Show();

            button.UseMTooltip();
            button2.UseMTooltip();
            button3.UseMTooltip();

            button.SetTooltipText("Button");

            button2.SetTooltipText("Tooltip Test");

            button3.SetTooltipText("#03A9F4");

            button3.Clicked += (s, e) =>
            {
                button2.SetTooltipText("Chage Tooltip");
            };

            box.PackEnd(button2);
            return box;
        }
    }
}
