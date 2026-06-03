feature/{{WBS-ID}}-{{short-description}}

bugfix/{{WBS-ID}}-{{short-description}}

hotfix/{{short-description}}

release/{{version}}

Examples:

  * feature/1.1.2-solution-layout
  * feature/1.3.2-oidc-middleware
  * bugfix/2.1.1-locations-siteCode-constraint


The WBS ID prefix is worth including because it ties every branch back to a task in your plan without needing a separate issue tracker right now.


Rules
* Branches cut from develop, not main
* Hotfixes cut from main and merged to both main and develop
* Delete branches after merge (keep the remote clean)
* No long-lived feature branches — if a task takes more than a day, commit WIP to the feature branch and open a draft PR
