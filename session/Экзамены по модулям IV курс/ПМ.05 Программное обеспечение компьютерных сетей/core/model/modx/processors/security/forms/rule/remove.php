<?php
/*
 * This file is part of MODX Revolution.
 *
 * Copyright (c) MODX, LLC. All Rights Reserved.
 *
 * For complete copyright and license information, see the COPYRIGHT and LICENSE
 * files found in the top-level directory of this distribution.
 */

/**
 * @package modx
 * @subpackage processors.security.forms.rule
 */
if (!$modx->hasPermission('customize_forms')) return $modx->error->failure($modx->lexicon('permission_denied'));
$modx->lexicon->load('formcustomization');

/* get rule */
if (empty($scriptProperties['id'])) return $modx->error->failure($modx->lexicon('rule_err_ns'));
$rule = $modx->getObject('modActionDom',$scriptProperties['id']);
if ($rule == null) return $modx->error->failure($modx->lexicon('rule_err_nf'));

/* remove rule */
if ($rule->remove() == false) {
    return $modx->error->failure($modx->lexicon('rule_err_remove'));
}

return $modx->error->success('',$rule);
