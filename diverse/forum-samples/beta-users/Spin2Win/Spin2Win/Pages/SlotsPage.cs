using System;
using System.Collections.Generic;
using Xamarin.Motion;
using Xamarin.QuickUI;

namespace Spin2Win
{
	public class SpinFinishedArgs : EventArgs 
	{
		public PrizeType Prize { get; private set; }
		public SpinFinishedArgs (PrizeType prize)
		{
			Prize = prize;
		}
	}

	public class SlotsPage : ContentPage
	{
		public event EventHandler<SpinFinishedArgs> SpinFinished;
		bool leftSlotFinished, centerSlotFinished, rightSlotFinished;
		bool isPhone = Device.Idiom == TargetIdiom.Phone;

		public SlotsPage ()
		{
			leftSlotFinished = centerSlotFinished = rightSlotFinished = false;

			BackgroundColor = Color.FromRgb (57, 57, 57);

			var leftMonkeys = new List<string> { "orange.png", "crazyface.png", "chimp.png", "blackmonkey.png" };
			var leftSlot = new Slot (leftMonkeys, SlotType.Left);

			var centerMonkeys = new List<string> { "orange.png", "blackmonkey.png", "pinkface.png", "chimp.png" };
			var centerSlot = new Slot (centerMonkeys, SlotType.Center);

			var rightMonkeys = new List<string> { "blackmonkey.png", "chimp.png", "crazyface.png", "orange.png" };
			var rightSlot = new Slot (rightMonkeys, SlotType.Right);

			var xamarinLogo = new Image {
				Source = "logoxamarin.png",
				BackgroundColor = Color.FromRgb (57, 57, 57)
			};

			var bottomRectangle = new BoxView {
				Color = Color.FromRgb (57, 57, 57)
			};

			var gradientTop = new Image {
				Source = "gradienttop.png"
			};

			var gradientBottom = new Image {
				Source = "gradient.png"
			};

			//WaitForSpin ();
			var monkeyLayout = new AbsoluteLayout ();
			monkeyLayout.SizeChanged += (sender, e) => {
				if (monkeyLayout.Bounds.Width == -1 || monkeyLayout.Bounds.Height == -1)
					return;

				var screenWidth = Bounds.Width;
				var screenHeight = Bounds.Height + 56;

				xamarinLogo.Bounds = new Rectangle (20, 0, screenWidth - 40, 200);

				var slotWidth = screenWidth / 4;
				var paddingWidth = screenWidth / 16;

				double x = paddingWidth;
				leftSlot.Bounds = new Rectangle (x, 200, slotWidth, screenWidth - 75);

				x += slotWidth + paddingWidth;
				centerSlot.Bounds = new Rectangle (x, 200, slotWidth, screenWidth - 75);

				x += slotWidth + paddingWidth;
				rightSlot.Bounds = new Rectangle (x, 200, slotWidth, screenWidth - 75);

				bottomRectangle.Bounds = new Rectangle (0, leftSlot.Bounds.Bottom, screenWidth, screenHeight - leftSlot.Bounds.Bottom);

				gradientTop.Bounds = new Rectangle (0, leftSlot.Bounds.Top - 2, screenWidth, 150);
				gradientBottom.Bounds = new Rectangle (0, leftSlot.Bounds.Bottom - 148, screenWidth, 150);

			};


			monkeyLayout.Add (leftSlot);
			monkeyLayout.Add (centerSlot);
			monkeyLayout.Add (rightSlot);
			monkeyLayout.Add (xamarinLogo);
			monkeyLayout.Add (bottomRectangle);
			monkeyLayout.Add (gradientTop);
			monkeyLayout.Add (gradientBottom);

			leftSlot.SpinSlot (1, 5, 0.003);
			centerSlot.SpinSlot (1.5, 5, 0.003);
			rightSlot.SpinSlot (2.0, 5, 0.003);

			leftSlot.SlotFinished += OnLeftSlotFinished;
			centerSlot.SlotFinished += OnCenterSlotFinished;
			rightSlot.SlotFinished += OnRightSlotFinished;

			Content = monkeyLayout;
		}
	
		void OnLeftSlotFinished (object sender, EventArgs eventArgs)
		{
			Console.WriteLine ("Left Slot Finished");
			SetFinishedState (SlotType.Left);
		}

		void OnCenterSlotFinished (object sender, EventArgs eventArgs)
		{
			Console.WriteLine ("Center Slot Finished");
			SetFinishedState (SlotType.Center);
		}

		void OnRightSlotFinished (object sender, EventArgs eventArgs)
		{
			Console.WriteLine ("Right Slot Finished");
			SetFinishedState (SlotType.Right);
		}

		void SetFinishedState (SlotType slot)
		{
			switch (slot) {
			case SlotType.Left:
				leftSlotFinished = true;
				break;
			case SlotType.Center:
				centerSlotFinished = true;
				break;
			case SlotType.Right:
				rightSlotFinished = true;
				break;
			}

			if (leftSlotFinished && centerSlotFinished && rightSlotFinished) {
				var handler = SpinFinished;
				if (handler != null) {
					var args = new SpinFinishedArgs (PrizeType.Monkey);
					handler (this, args);
				}
			}
				
		}
	}

	public enum SlotType
	{
		Left,
		Center,
		Right
	}

	public class Slot : AbsoluteLayout
	{
		public event EventHandler SlotFinished;

		List<string> monkeys;
		List<Image> monkeyImages;
		Double monkeySize;

		public Slot (List<string> monkeyList, SlotType slotType)
		{

			monkeys = monkeyList;
			monkeyImages = new List<Image> ();

			foreach (var monkey in monkeys) {
				var monkeyImage = CreateMonkey (monkey);
				monkeyImages.Add (monkeyImage);
				Add (monkeyImage);
			}
	
		}

		protected override void LayoutChildren (double x, double y, double width, double height)
		{
			var size = width;
			monkeySize = size;

			var monkeyY = y - (monkeySize * 1.2);
			foreach (var monkey in monkeyImages) {
				monkey.Bounds = new Rectangle (0, monkeyY, monkeySize, monkeySize);
				monkeyY += monkeySize * 1.2;
			}
		
		}

		public void SpinSlot (double delayBeforeSpin, double initialVelocity, double drag)
		{
			Device.StartTimer (TimeSpan.FromSeconds (delayBeforeSpin), () => {
				this.AnimateKinetic ("SlotRoll", (normalizedMotion, instantaneousVelocity) => {
					foreach (var monkeyImage in monkeyImages) {
						monkeyImage.Y += normalizedMotion;
						if (monkeyImage.Y > Bounds.Height) {
							monkeyImage.Y -= (Bounds.Height + (monkeySize * 1.2));
						}
					}
					return true;
				}, initialVelocity, drag, () => {
					var handler = SlotFinished;
					if (handler != null)
						handler (this, EventArgs.Empty);
				});
				return false;
			});
			
		}

		Image CreateMonkey (string imagePath)
		{
			var monkey = new Image {
				Source = imagePath
			};
			return monkey;
		}
	}
}