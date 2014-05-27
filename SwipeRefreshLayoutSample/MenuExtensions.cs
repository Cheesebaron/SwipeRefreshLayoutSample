using Android.Content;
using Android.Graphics;
using Android.Views;

namespace SwipeRefreshLayoutSample
{
    public static class MenuExtensions
    {
        public static IMenuItem SetEnabled(this IMenuItem item, bool enabled, Context context, int iconId)
        {
            return item.SetEnabled(enabled, context, iconId, Color.Gray);
        }

        public static IMenuItem SetEnabled(this IMenuItem item, bool enabled, Context context, int iconId, Color disabledColor)
        {
            var resIcon = context.Resources.GetDrawable(iconId);

            if (!enabled)
                resIcon.Mutate().SetColorFilter(disabledColor, PorterDuff.Mode.SrcIn);

            item.SetEnabled(enabled);
            item.SetIcon(resIcon);

            return item;
        }
    }
}