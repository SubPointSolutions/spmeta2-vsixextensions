using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMeta2.VS.CSharp.ProvisionConsole.Services
{
    public class ConsoleAppService
    {
        public void Run(string[] args)
        {
            HandleConfigOverrides(args);
            AppSettingsUtils.TraceSettingsToConsole(typeof(AppSettings));

            Confirm("Press any key to continue provisioning...", ShouldAskForConfirmationParam(args));
            Confirm("Starting provision...", false);

            WithTimeTrace(() =>
            {
                PreProvisionRoutins();
                ProvisionIntranet();
                PostProvisioningRoutines();
            });
        }

        public virtual void ProvisionIntranet()
        {
            // deploy intranet here
            // use AppSettings to sort out what to deploy and what not 
        }

        protected virtual void PostProvisioningRoutines()
        {

        }

        protected virtual void PreProvisionRoutins()
        {

        }

        protected virtual void WithTimeTrace(Action action)
        {
            var startTime = DateTime.Now;

            action();

            var timespan = DateTime.Now - startTime;

            Confirm(string.Format("Provision was completed.\nElapsedtime: [{0}] \n\nPress any key to continue...", timespan.ToString(@"hh\:mm\:ss\.ff")), shouldConfirm);
        }

        protected virtual void HandleConfigOverrides(string[] args)
        {
            var siteUrl = GetSiteUrlParam(args);

            // overriding from the console param
            if (!string.IsNullOrEmpty(siteUrl))
                AppSettings.IntranetUrl = siteUrl;
        }

        ///// <summary>
        ///// Draws a nasty progress bar to a console :)
        ///// </summary>
        ///// <param name="provisionService"></param>
        //protected void AttachConsoleProgressTrace(ProvisionServiceBase provisionService)
        //{
        //    provisionService.OnModelNodeProcessed += (sender, args) =>
        //    {
        //        Console.WriteLine(string.Empty);
        //        DrawTextProgressBar(args.ProcessedModelNodeCount, args.TotalModelNodeCount);
        //        Console.WriteLine(string.Empty);

        //        var message = string.Format("Processed: [{0}/{1}] - [{2:00.0} %] - [{3}] [{4}]",
        //            new object[]
        //            {
        //                args.ProcessedModelNodeCount,
        //                args.TotalModelNodeCount,
        //                100d*(double) args.ProcessedModelNodeCount/(double) args.TotalModelNodeCount,
        //                args.CurrentNode.Value.GetType().Name,
        //                args.CurrentNode.Value
        //            });

        //        Trace.WriteLine(message);
        //        Console.WriteLine(message);
        //    };
        //}

        #region utils

        protected virtual void DrawTextProgressBar(int progress, int total)
        {
            try
            {

                //draw empty progress bar
                Console.CursorLeft = 0;
                Console.Write("["); //start
                Console.CursorLeft = 32;
                Console.Write("]"); //end
                Console.CursorLeft = 1;
                float onechunk = 30.0f / total;

                //draw filled part
                int position = 1;
                for (int i = 0; i < onechunk * progress; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.CursorLeft = position++;
                    Console.Write(" ");
                }

                //draw unfilled part
                for (int i = position; i <= 31; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.CursorLeft = position++;
                    Console.Write(" ");
                }

                //draw totals
                Console.CursorLeft = 35;
                Console.BackgroundColor = ConsoleColor.Black;
                // Console.Write(progress.ToString() + " of " + total.ToString() + "    "); //blanks at the end remove any excess
            }
            catch (Exception e)
            {

            }
        }

        protected virtual void Confirm(string message)
        {
            Confirm(message, true);
        }

        protected virtual void Confirm(string message, bool shouldConfirm)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);

            if (shouldConfirm)
                Console.ReadKey();

            Console.ResetColor();
        }

        protected virtual bool ShouldAdkForConfirmationParam(string[] args)
        {
            var value = GetArgValue(args, "shouldAskForConfirmation");

            if (!string.IsNullOrEmpty(value))
            {
                Console.Write("Converting...");
                Console.Write(value);
                Console.WriteLine();
                return Convert.ToBoolean(value);
            }

            return true;
        }

        protected virtual string GetSiteUrlParam(string[] args)
        {
            return GetArgValue(args, "siteUrl");
        }

        protected virtual string GetArgValue(string[] args, string propName)
        {
            var arg = args.FirstOrDefault(s => !string.IsNullOrEmpty(s) && s.ToUpper().StartsWith("-" + propName.ToUpper()));

            if (arg != null)
            {
                var parts = arg.Split(':');

                if (parts.Count() > 1)
                {
                    var valueParts = parts.ToList();
                    valueParts.RemoveAt(0);

                    return string.Join(":", valueParts);
                }
            }

            return string.Empty;
        }

        #endregion
    }
}
