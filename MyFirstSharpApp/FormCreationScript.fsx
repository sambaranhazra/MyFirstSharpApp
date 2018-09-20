open System
open System.Net
open System.Windows.Forms

let webClient = new WebClient()

let fSharpOrg = webClient.DownloadString(Uri "http://www.google.com")
let browser = new WebBrowser(ScriptErrorsSuppressed = true, Dock = DockStyle.Fill, DocumentText = fSharpOrg)
let form = new Form(Text = "Hello from F#!")

form.Controls.Add browser
form.Show()
