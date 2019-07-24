import { Component } from '@angular/core';

/**
 * Integration component containing no view, acts as browserPolyfill,
 * supporting the case for custom elements.
 *
 * Serves the purpose of defining customElements
 *
 * To stay within the app, and to comply with the cli's "serve"
 * command, the AppModule bootstraps MasterLayoutComponent as
 * a replacement
 */
@Component({
  selector: 'integration',
  template: String(),
})
export class AppIntegrationComponent {}
